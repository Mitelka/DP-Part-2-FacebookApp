namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public class GeneratorGreetingCardFacade
    {
        private GeneratorGreetingCardLogic m_GeneratorGreetingCardLogic;

        public GeneratorGreetingCardFacade()
        {
            m_GeneratorGreetingCardLogic = new GeneratorGreetingCardLogic();
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return m_GeneratorGreetingCardLogic.GetFriends();
        }

        public void PostPhoto(string i_FileName, string i_TitleOfPic)
        {
            m_GeneratorGreetingCardLogic.PostPhoto(i_FileName, i_TitleOfPic);
        }
    }
}
