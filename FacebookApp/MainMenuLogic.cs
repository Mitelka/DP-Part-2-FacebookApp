namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    internal class MainMenuLogic
    {
        private User m_LoggedInUser;

        public MainMenuLogic()
        {
            UserFacebookApp TheUser = Singleton<UserFacebookApp>.Instance;
            m_LoggedInUser = Singleton<UserFacebookApp>.Instance.LoggedInUser;
        }

        public string GetProfilePicUrl()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public string GetFirstNameOfUser()
        {
            return m_LoggedInUser.FirstName;
        }

        public Photo FindPopularPhoto()
        {
            int maxLikes = int.MinValue;
            Photo maxPhoto = null;
            foreach (Album album in m_LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    int numOfLikesPhoto = photo.LikedBy.Count;
                    if (maxLikes < numOfLikesPhoto)
                    {
                        maxLikes = numOfLikesPhoto;
                        maxPhoto = photo;
                    }
                }
            }

            return maxPhoto;
        }

        public void PostPhoto(string i_FileName, string i_TitleOfPic)
        {
            m_LoggedInUser.PostPhoto(i_FileName, i_TitleOfPic);
        }
    }
}
