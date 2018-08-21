namespace FacebookApp
{
    using System;
    using FacebookWrapper.ObjectModel;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class PickYourLoveFormUI : Form
    {
        List<User> m_Matches;

        public PickYourLoveFormUI(List<User> i_Matches)
        {
            InitializeComponent();
            m_Matches = i_Matches;
            showMatches();
        }

        private void PickYourLoveForm_Load(object sender, EventArgs e)
        {
        }

        private void showMatches()
        {
            matchesListbox.Items.Clear();
            matchesListbox.DisplayMember = "Name";
            foreach (User match in m_Matches)
            {
                matchesListbox.Items.Add(match);
            }
        }

        private void matchesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchesListbox.SelectedItem != null)
            {
                User selcetedUser = matchesListbox.SelectedItem as User;
                profilePic.ImageLocation = selcetedUser.PictureNormalURL;
                profilePic.Load();
            }
        }
    }
}
