namespace FacebookApp
{
    using System;

    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;
    using static FacebookWrapper.ObjectModel.User;

    public partial class MatchingFormUI : Form
    {
        private eGender m_Gender;
        private MatchingFormFacade m_Facade;

        public MatchingFormUI(MatchingFormFacade i_Facade)
        {
            m_Facade = i_Facade;
            InitializeComponent();
            showProfilePic();
            interstingLabel.Font = new Font("Ariel", 9.7f, FontStyle.Underline);
            ageRangeLabel.Font = new Font("Ariel", 9.7f, FontStyle.Underline);
            fromTrack.Minimum = 18;
            fromTrack.Maximum = 99;
            ToTrackBar.Minimum = 18;
            ToTrackBar.Maximum = 99;
        }

        private void showProfilePic()
        {
            profilePic.ImageLocation = m_Facade.GetProfilePicUrl();
            profilePic.Load();
        }

        private void MatchingForm_Load(object sender, EventArgs e)
        {
        }

        private void femaleChecked(object sender, EventArgs e)
        {
            m_Gender = eGender.female;
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            m_Gender = eGender.male;
        }
       
        private void fromTrackScroll(object sender, EventArgs e)
        {
            fromRangeChosen.Text = fromTrack.Value.ToString();
        }

        private void ToTrackBar_Scroll(object sender, EventArgs e)
        {
            maxRangeChosen.Text = ToTrackBar.Value.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool isAgeValid = checkAgeValidation();
            List<User> matches = new List<User>();
            if (!isAgeValid)
            {
                MessageBox.Show("Please choose a valid range age!");
            }
            else
            {
                matches = m_Facade.FindMatches(m_Gender, fromTrack.Value, ToTrackBar.Value);
                if (matches.Count > 0)
                {
                    new PickYourLoveFormUI(matches).Show();
                }
                else
                {
                    MessageBox.Show("You don't have any matches... Sorry :(");
                }
            }
        }

        private bool checkAgeValidation()
        {
            bool isValid = false;
            if (fromTrack.Value <= ToTrackBar.Value)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
