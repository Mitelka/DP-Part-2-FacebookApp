using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class JustLoginToFacebook : Form
    {
        public JustLoginToFacebook()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            const string appIdValue = "1914992165220174";
            AppId appId = new AppId(appIdValue);
            UserFacebookApp.s_AppId = appId;

            try
            {
                UserFacebookApp TheUser = Singleton<UserFacebookApp>.Instance;
                new MainMenuUI(new MainMenuFacade()).ShowDialog();
            }
            catch (LoggedInException i_LoggedInException)
            {
                MessageBox.Show(i_LoggedInException.Message);

            }
        }
    }
}
