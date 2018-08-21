namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public class GeneratorGreetingCardLogic
    {
        private User m_LoggedInUser;

        public GeneratorGreetingCardLogic()
        {
            m_LoggedInUser = Singleton<UserFacebookApp>.Instance.LoggedInUser;
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return m_LoggedInUser.Friends;
        }

        public void PostPhoto(string i_FileName, string i_TitleOfPic)
        {
            m_LoggedInUser.PostPhoto(i_FileName, i_TitleOfPic);
        }
    }
}
