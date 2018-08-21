namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;

    public partial class GeneratorGreetingCardFormUI : Form
    {
        private GreetingCard m_GreetingCard = null;
        private GeneratorGreetingCardFacade m_Facade;
        private string m_PathTempToSave = Path.Combine(Path.GetTempPath(), "GreetingCard.png");

        public GeneratorGreetingCardFormUI()
        {
            m_Facade = new GeneratorGreetingCardFacade();
            InitializeComponent();
            showGreetingCardButton.Enabled = false;
            postTheGreetingCardButton.Enabled = false;
            new Thread(showFriends).Start();
            showGreetingCardOptions();
        }

        private void showFriends()
        {
            try
            {
                this.Invoke(new Action(() => this.ControlBox = false));
                friendsListBox.Invoke(new Action(() => friendsListBox.DisplayMember = "Name"));
                FacebookObjectCollection<User> friendsList = m_Facade.GetFriends();
                foreach (User friend in friendsList)
                {
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(friend)));
                }

                this.Invoke(new Action(() => this.ControlBox = true));
            }
            catch (InvalidOperationException i_Exception)
            {
            }
        }

        private void showGreetingCardPhoto(object sender, EventArgs e)
        {
            m_GreetingCard = GreetingCardFactory.Create(friendsListBox.SelectedItem as User, (eGreetingCardType) listBoxGreetingCardOptions.SelectedItem);
            m_GreetingCard.ShowGreetingCard();
            m_GreetingCard.GreetingCardForm.ControlBox = false;
            saveGreetingCard();
            m_GreetingCard.GreetingCardForm.ControlBox = true;
            postTheGreetingCardButton.Enabled = true;
        }

        private void saveGreetingCard()
        {
            using (Bitmap bmp = new Bitmap(m_GreetingCard.GreetingCardForm.Width, m_GreetingCard.GreetingCardForm.Height))
            {
                m_GreetingCard.GreetingCardForm.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                bmp.Save(m_PathTempToSave, ImageFormat.Png);
            }
        }

        private void showGreetingCardOptions()
        {
            foreach (eGreetingCardType type in Enum.GetValues(typeof(eGreetingCardType)))
            {
                listBoxGreetingCardOptions.Items.Add(type);
            }
        }

        private void GeneratorGreetingCardForm_Load(object sender, EventArgs e)
        {
        }

        private void listBoxGreetingCardOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGreetingCardOptions.SelectedItem != null && friendsListBox.SelectedItem != null)
            {
                showGreetingCardButton.Enabled = true;
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (friendsListBox.SelectedItem != null && listBoxGreetingCardOptions.SelectedItem != null)
            {
                showGreetingCardButton.Enabled = true;
            }
        }

        private void postTheGreetingCardButton_Click(object sender, EventArgs e)
        {
            m_Facade.PostPhoto(m_PathTempToSave, string.Format("Congrats {0}!", m_GreetingCard.Receiver.Name));
            MessageBox.Show("Posted!");
        }
    }
}
