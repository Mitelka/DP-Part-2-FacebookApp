using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class MainMenuFacade
    {
        private MainMenuLogic m_MenuLogic;

        public MainMenuFacade()
        {
            m_MenuLogic = new MainMenuLogic();
        }

        public string GetProfilePicUrl()
        {
            return m_MenuLogic.GetProfilePicUrl();
        }

        public string GetFirstNameOfUser()
        {
            return m_MenuLogic.GetFirstNameOfUser();
        }

        public Photo FindPopularPhoto()
        {
            return m_MenuLogic.FindPopularPhoto();
        }

        public void PostPhoto(string i_FileName, string i_TitleOfPic)
        {
            m_MenuLogic.PostPhoto(i_FileName, i_TitleOfPic);
        }
    }
}
