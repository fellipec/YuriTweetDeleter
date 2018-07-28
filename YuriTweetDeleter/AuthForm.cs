using System;
using System.Diagnostics;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;

namespace YuriTweetDeleter
{
    public partial class AuthForm : Form
    {
     
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Shows a confirmation dialog
            DialogResult confirmReset = MessageBox.Show("Are you sure to reset the authenticated user?", "Reset Authentication", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmReset == DialogResult.Yes)
            {
                // Clean the user authentication settings
                Properties.Settings.Default.AccessToken = "";
                Properties.Settings.Default.AccessTokenSecret = "";
                Properties.Settings.Default.Save();

                MessageBox.Show("Credentials reseted");
            }
        }

        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            // Create a new set of credentials for the application.
            string CKey = Properties.Settings.Default.ConsumerKey;
            string CSecret = Properties.Settings.Default.ConsumerSecret;
            TwitterCredentials appCredentials = new TwitterCredentials(CKey, CSecret);

            // Init the authentication process and store the related `AuthenticationContext`.
            Program.AuthenticationContext = AuthFlow.InitAuthentication(appCredentials);

            // Go to the URL so that Twitter authenticates the user and gives him a PIN code.
            Process.Start(Program.AuthenticationContext.AuthorizationURL);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Ask the user to enter the pin code given by Twitter
            var pinCode = textBoxConfirmationCode.Text;


            // With this pin code it is now possible to get the credentials back from Twitter
            var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, Program.AuthenticationContext);

            // Store the Tokens into Application Settings
            Properties.Settings.Default.AccessToken = userCredentials.AccessToken;
            Properties.Settings.Default.AccessTokenSecret = userCredentials.AccessTokenSecret;
            Properties.Settings.Default.Save();

            MessageBox.Show("Credentials saved!", "Success");

            this.Close();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            showHelp();
        }

        private void AuthForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            showHelp();
        }

        private void showHelp()
        {
            Process.Start("https://github.com/fellipec/YuriTweetDeleter/wiki/Authentication");
        }
    }
}
