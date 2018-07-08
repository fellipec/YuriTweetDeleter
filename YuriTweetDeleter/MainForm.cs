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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Auth.SetUserCredentials(Properties.Settings.Default.ConsumerKey,
                                    Properties.Settings.Default.ConsumerSecret,
                                    Properties.Settings.Default.AccessToken,
                                    Properties.Settings.Default.AccessTokenSecret);


            var authenticatedUser = User.GetAuthenticatedUser();

            if (authenticatedUser == null)
            {
                AuthForm AF = new AuthForm();
                AF.ShowDialog();
            }
            else
            {
                this.Text = this.Text + " - " + authenticatedUser.UserIdentifier;
            }
            
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            panelLog.Height = Convert.ToInt32(this.Height / 5);
        }


        private void buttonSelectTweets_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            progressBar1.Maximum = dataGridViewTweets.Rows.Count;
            progressBar1.Value = 0;

            // Instantiate the regular expression object.
            Regex rxp = new Regex(textBoxKeywords.Text, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            foreach (DataGridViewRow r in dataGridViewTweets.Rows)
            {                
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
            textBoxLog.AppendText(dataGridViewTweets.SelectedRows.Count.ToString() + " tweets selected \n");
            Cursor.Current = Cursors.Default;
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete " + dataGridViewTweets.SelectedRows.Count.ToString() + " tweets? THIS CAN'T BE UNDONE!", "Last chance", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                progressBar1.Maximum = dataGridViewTweets.SelectedRows.Count;
                progressBar1.Value = 0;

                foreach (DataGridViewRow r in dataGridViewTweets.SelectedRows)
                {
                    long tID = Convert.ToInt64( r.Cells["tweet_id"].Value );
                    Tweet.DestroyTweet(tID);
                    textBoxLog.AppendText("Deleting tweet ID: " + tID.ToString() + "\n");
                    progressBar1.Value++;
                }
                Cursor.Current = Cursors.Default;
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("That was close!");
            }
        }

        private void buttonLoadTweets_Click(object sender, EventArgs e)
        {
            // Opens the Tweet Archvie CSV

            openFileDialogTweets.ShowDialog();            
            var fileTweets = openFileDialogTweets.FileName;

            // Set the cursor for hourglass
            Cursor.Current = Cursors.WaitCursor;

            // Open the Twitter CSV File and load into the DataGridView
            using (CachedCsvReader csv = new CachedCsvReader(
                                   new StreamReader(fileTweets), true))
            {
                dataGridViewTweets.DataSource = csv;
            }

            // Set Start and Minimum filter dates
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

            // Log
            textBoxLog.AppendText(dataGridViewTweets.Rows.Count.ToString() + " tweets loaded \n");
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
                this.Text = this.Text + " - " + authenticatedUser.UserIdentifier;
            }

        }
    }
}
