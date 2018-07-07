using System;
using System.Diagnostics;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;

namespace YuriTweetDeleter
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new set of credentials for the application.
            var appCredentials = new TwitterCredentials("REClvhX7WZsQV7f9wJspcZj0s", "JUqG0tznaCr4EIvRjKDZpHeVl7g0g7cDqUzLrl4K9AN0N2Y6Vt");

            // Init the authentication process and store the related `AuthenticationContext`.
            var authenticationContext = AuthFlow.InitAuthentication(appCredentials);

            // Go to the URL so that Twitter authenticates the user and gives him a PIN code.
            Process.Start(authenticationContext.AuthorizationURL);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ask the user to enter the pin code given by Twitter
            var pinCode = Console.ReadLine();

            // With this pin code it is now possible to get the credentials back from Twitter
            var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);

            // Use the user credentials in your application
            Auth.SetCredentials(userCredentials);
        }
    }
}
