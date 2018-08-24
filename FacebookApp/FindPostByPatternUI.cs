namespace FacebookApp
{
    using System;
    using System.Windows.Forms;
    using System.Threading;

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
            searchButton.Invoke(new Action(() => this.searchButton.Text = "Searching..."));
            searchButton.Invoke(new Action(() => this.searchButton.Enabled = false));
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

                searchButton.Invoke(new Action(() => this.searchButton.Text = originalText));
                searchButton.Invoke(new Action(() => this.searchButton.Enabled = true));
            }
        }
    }
}
