namespace FacebookApp
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public partial class LoginFacebook : Form
    {
        public LoginFacebook()
        {
            InitializeComponent();
            showComboBoxAppIds();
            FacebookWrapper.FacebookService.s_CollectionLimit = int.MaxValue;
        }

        private void loginFacebook_Click(object sender, EventArgs e)
        {
            if (appIdComboBox.SelectedItem != null)
            {
                string appIdChosen = (appIdComboBox.SelectedItem as AppId).Value;
                UserFacebookApp.s_AppId = appIdChosen;
                try
                {
                    UserFacebookApp loggedInUser = Singleton<UserFacebookApp>.Instance;
                    new MainMenuUI(new MainMenuFacade()).ShowDialog();
                    this.Close();
                }
                catch (LoggedInException i_LoggedInException)
                {
                    MessageBox.Show(i_LoggedInException.Message);
                }
            }
            else
            {
                MessageBox.Show("Please choose app id to login");
            }
        }

        private void showComboBoxAppIds()
        {
            const string appId1Value = "1529887743753944";
            const string appId2Value = "1450160541956417";
            AppId appId1 = new AppId(appId1Value);
            AppId appId2 = new AppId(appId2Value);
            appIdComboBox.DisplayMember = "Value";
            appIdComboBox.Items.Add(appId1);
            appIdComboBox.Items.Add(appId2);
        }

        private void LoginFacebook_Load(object sender, EventArgs e)
        {
        }
    }
}
