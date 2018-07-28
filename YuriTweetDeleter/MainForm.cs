using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace YuriTweetDeleter
{
    public partial class MainForm : Form
    {
        const string formTitle = "Yuri Tweet Deleter";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            loadCredentials();
            
        }

        private void loadCredentials()
        {
            // Load saved OAuth credentials
            Auth.SetUserCredentials(Properties.Settings.Default.ConsumerKey,
                                    Properties.Settings.Default.ConsumerSecret,
                                    Properties.Settings.Default.AccessToken,
                                    Properties.Settings.Default.AccessTokenSecret);

            // Gets the User Object from TWitter
            var authenticatedUser = User.GetAuthenticatedUser();

            // Shows the Authentication dialog if there is no authenticated user.
            if (authenticatedUser == null)
            {
                AuthForm AF = new AuthForm();
                AF.ShowDialog();
                loadCredentials();
            }
            else
            {
                // Shows the @ username in titlebar
                setTitlebar(authenticatedUser.UserIdentifier.ToString());
            }
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Keeps the log to 1/5 of the window height
            panelLog.Height = Convert.ToInt32(this.Height / 5);
        }


        private void buttonSelectTweets_Click(object sender, EventArgs e)
        {
            // Set waiting mouse cursor and progress bar
            Cursor.Current = Cursors.WaitCursor;
            progressBar1.Maximum = dataGridViewTweets.Rows.Count;
            progressBar1.Value = 0;

            // Instantiate the regular expression object.
            Regex rxp = new Regex(textBoxKeywords.Text, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            // Updates log
            textBoxLog.AppendText("Selecting tweets between " + dateTimePickerStart.Value.ToString() 
                                 +" and " + dateTimePickerEnd.Value.ToString() 
                                 + "that matches the '" + textBoxKeywords.Text + "' regex\n");
                        
            foreach (DataGridViewRow r in dataGridViewTweets.Rows)
            {
                // Check if the tweet meets user selection criteria and selects it
                if (Convert.ToDateTime(r.Cells["timestamp"].Value) > dateTimePickerStart.Value &&
                    Convert.ToDateTime(r.Cells["timestamp"].Value) < dateTimePickerEnd.Value &&
                    rxp.Match(r.Cells["text"].Value.ToString()).Success)
                {
                    r.Selected = true;
                }
                else
                {
                    r.Selected = false;
                }
                progressBar1.Value++;
            }

            // Update log and resets mouse cursor
            textBoxLog.AppendText(dataGridViewTweets.SelectedRows.Count.ToString() + " tweets selected \n");
            Cursor.Current = Cursors.Default;
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {

            // Shows a confirmation dialog
            DialogResult confirmDelete = MessageBox.Show("Are you sure to delete " + dataGridViewTweets.SelectedRows.Count.ToString() + " tweets? THIS CAN'T BE UNDONE!", "Last chance", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (confirmDelete == DialogResult.Yes)
            {
                // Sets mouse cursor and progress bar
                Cursor.Current = Cursors.WaitCursor;
                progressBar1.Maximum = dataGridViewTweets.SelectedRows.Count;
                progressBar1.Value = 0;

                // Sends delete command to Twitter
                foreach (DataGridViewRow r in dataGridViewTweets.SelectedRows)
                {
                    long tID = Convert.ToInt64( r.Cells["tweet_id"].Value );
                    Tweet.DestroyTweet(tID);
                    textBoxLog.AppendText("Deleting tweet ID: " + tID.ToString() + "\n");
                    progressBar1.Value++;
                }
                Cursor.Current = Cursors.Default;
            }
            else if (confirmDelete == DialogResult.No)
            {
                MessageBox.Show("That was close!","Nothing done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void buttonLoadTweets_Click(object sender, EventArgs e)
        {
            // Opens the Tweet Archvie CSV
            openFileDialogTweets.ShowDialog();            
            var fileTweets = openFileDialogTweets.FileName;

            // Set the mouse cursor 
            Cursor.Current = Cursors.WaitCursor;

            // Update log
            textBoxLog.AppendText("Loading tweets from file: "+ fileTweets.ToString() +"\n");

            // Open the Twitter CSV File and load into the DataGridView
            Boolean loadSucess = false;
            try
            {
                using (CachedCsvReader csv = new CachedCsvReader(
                       new StreamReader(fileTweets), true))
                {
                    dataGridViewTweets.DataSource = csv;
                }
                loadSucess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Twitter archive", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBoxLog.AppendText("Error loading tweet archive: " + ex.Message);
            }

            // Checks if the CSV loaded is really a Twitter Archive
            if (loadSucess)
            {
                if (dataGridViewTweets.Columns[0].Name != "tweet_id")
                {
                    MessageBox.Show("The file is not a valid Twitter archive", "Error parsing Twitter archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxLog.AppendText("Error parsing tweet archive: The file is not a valid Twitter archive\n");
                    loadSucess = false;
                }
            }


            if (loadSucess) // Avoids running next block if can't load the CSV file
            {

                // Set Start and Minimum filter dates
                // Start Date is set to the day that Twitter account was created
                // End Date is set to now. This ensure that if the user didn't touch the datepickers and only type 
                // a word filter, the program will search through all the tweets.
                var authenticatedUser = User.GetAuthenticatedUser();
                dateTimePickerStart.MinDate = authenticatedUser.CreatedAt;
                dateTimePickerStart.Value = authenticatedUser.CreatedAt;
                dateTimePickerEnd.MinDate = authenticatedUser.CreatedAt;
                dateTimePickerEnd.Value = DateTime.Now;

                // Hide irrelevant columns 
                dataGridViewTweets.Columns["in_reply_to_status_id"].Visible = false;
                dataGridViewTweets.Columns["in_reply_to_user_id"].Visible = false;
                dataGridViewTweets.Columns["source"].Visible = false;
                dataGridViewTweets.Columns["retweeted_status_id"].Visible = false;
                dataGridViewTweets.Columns["retweeted_status_user_id"].Visible = false;
                dataGridViewTweets.Columns["retweeted_status_timestamp"].Visible = false;
                dataGridViewTweets.Columns["expanded_urls"].Visible = false;

                // Format columns
                dataGridViewTweets.Columns["tweet_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewTweets.Columns["timestamp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewTweets.Columns["text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Update log
                textBoxLog.AppendText(dataGridViewTweets.Rows.Count.ToString() + " tweets loaded \n");
            }
            // Resets mouse cursor
            Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthForm AF = new AuthForm();
            AF.ShowDialog();

            var authenticatedUser = User.GetAuthenticatedUser();

            if (authenticatedUser == null)
            {
                MessageBox.Show("User not authenticated");
            }
            else
            {
                setTitlebar(authenticatedUser.UserIdentifier.ToString());
            }

        }

        private void setTitlebar(string authUser)
        {
            // Shows the @ username in titlebar
            this.Text = formTitle + " - @" + authUser;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Best place to read about this software
            Process.Start("https://github.com/fellipec/YuriTweetDeleter/wiki");
        }
    }
}
