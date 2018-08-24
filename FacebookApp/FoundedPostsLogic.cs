namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public class FoundedPostsLogic
    {
        private User m_LoggedInUser;

        public FoundedPostsLogic()
        {
            m_LoggedInUser = Singleton<UserFacebookApp>.Instance.LoggedInUser;
        }

        public FacebookObjectCollection<Post> FindPostsByPattern(string i_Pattern, eResultTypes i_ResultType)
        {
            FacebookObjectCollection<Post> allPosts = m_LoggedInUser.Posts;
            FacebookObjectCollection<Post> foundedPosts = new FacebookObjectCollection<Post>();
            bool isFoundPost = false;
            foreach (Post post in allPosts)
            {
                string messagePost = post.Message;
                if (messagePost != null && messagePost.Contains(i_Pattern))
                {
                    foundedPosts.Add(post);
                    isFoundPost = true;
                }

                if (isFoundPost && i_ResultType == eResultTypes.FirstPost)
                {
                    break;
                }
            }

            return foundedPosts;
        }
    }
}
