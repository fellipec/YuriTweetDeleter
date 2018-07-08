using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi.Models;

namespace YuriTweetDeleter
{
    static class Program
    {
        
        private static IAuthenticationContext _authenticationContext;

        public static IAuthenticationContext AuthenticationContext
        {
            get { return _authenticationContext; }
            set { _authenticationContext = value; }
        }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
