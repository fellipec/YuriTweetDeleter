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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Ask the user to enter the pin code given by Twitter
            var pinCode = textBox1.Text;
                        

            // With this pin code it is now possible to get the credentials back from Twitter
            var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, Program.AuthenticationContext);

            // Store the Tokens into Application Settings
            Properties.Settings.Default.AccessToken = userCredentials.AccessToken;
            Properties.Settings.Default.AccessTokenSecret = userCredentials.AccessTokenSecret;
            Properties.Settings.Default.Save();

            MessageBox.Show(userCredentials.AccessToken);

            this.Close();

        }
    }
}
