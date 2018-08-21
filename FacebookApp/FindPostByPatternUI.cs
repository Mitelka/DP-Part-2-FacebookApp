namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Threading;
    using FacebookWrapper.ObjectModel;

    public partial class FindPostByPatternUI : Form
    {
        private MainMenuFacade m_Facade;

        public FindPostByPatternUI(MainMenuFacade i_Facade)
        {
            m_Facade = i_Facade;
            InitializeComponent();
        }

        private void FindPostByWord_Load(object sender, EventArgs e)
        {
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            new Thread(search).Start();
        }

        private void search()
        {
            string originalText = this.searchButton.Text;
            this.searchButton.Invoke(new Action(() => this.searchButton.Text = "Searching..."));
            this.searchButton.Invoke(new Action(() => this.searchButton.Enabled = false));
            if (string.IsNullOrEmpty(patternTextBox.Text))
            {
                MessageBox.Show("You didn't enter a pattern! Please type a pattern and then press the search button.");
            }
            else
            {
                if (firstPostRadio.Checked)
                {
                    FoundedPostsUI foundedPostsUI = new FoundedPostsUI(patternTextBox.Text, eResultTypes.FirstPost);
                    this.Invoke(new Action(() => foundedPostsUI.Show()));
                }
                else
                {
                    FoundedPostsUI foundedPostsUI = new FoundedPostsUI(patternTextBox.Text, eResultTypes.AllPosts);
                    this.Invoke(new Action(() => foundedPostsUI.Show()));
                }

                this.searchButton.Invoke(new Action(() => this.searchButton.Text = originalText));
                this.searchButton.Invoke(new Action(() => this.searchButton.Enabled = true));
            }
        }
    }
}
