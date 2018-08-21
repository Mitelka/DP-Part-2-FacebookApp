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

    public partial class FoundedPostsUI : Form
    {
        private string m_Pattern;
        private eResultTypes m_ResultType;
        private FoundedPostsFacade m_Facade;

        public FoundedPostsUI(string i_Pattern, eResultTypes i_ResultType)
        {
            m_Facade = new FoundedPostsFacade();
            m_Pattern = i_Pattern;
            m_ResultType = i_ResultType;
            InitializeComponent();
            findPosts();
        }

        private void FoundedPosts_Load(object sender, EventArgs e)
        {
        }

        private void findPosts()
        {
            FacebookObjectCollection<Post> foundedPosts = m_Facade.FindPostsByPattern(m_Pattern, m_ResultType);
            foundedPostText.Text = string.Empty;
            int counterPosts = 1;
            bool isFoundPost = false;
            foreach (Post post in foundedPosts)
            {
                foundedPostText.Text += string.Format(
                        @"Post number {0}:
The post was created in: {1}
The post content:
",
counterPosts,
post.CreatedTime.ToString());
                foundedPostText.Text += string.Format(
                    @"{0}

",
                    post.Message);
                counterPosts++;
                isFoundPost = true;
            }
            if (!isFoundPost)
            {
                foundedPostText.Text = "No results for this pattern.";
            }
        }
    }
}
