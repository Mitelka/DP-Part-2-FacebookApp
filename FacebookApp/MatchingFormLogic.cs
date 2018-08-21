namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using static FacebookWrapper.ObjectModel.User;
    using FacebookWrapper.ObjectModel;

    public class MatchingFormLogic
    {
        private User m_LoggedInUser;
        
        public MatchingFormLogic()
        {
            m_LoggedInUser = Singleton<UserFacebookApp>.Instance.LoggedInUser;
        }

        public string GetProfilePicUrl()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public List<User> FindMatches(eGender i_Gender, int i_MinAge, int i_MaxAge)
        {
            List<User> matches = new List<User>();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                if (checkIfMatch(friend, i_Gender, i_MinAge, i_MaxAge))
                {
                    matches.Add(friend);
                }
            }
            return matches;
        }

        private bool checkIfMatch(User i_User, eGender i_Gender, int i_MinAge, int i_MaxAge)
        {
            bool isMatch = true;
            if (i_User.Gender != i_Gender)
            {
                isMatch = false;
            }

            if (isMatch)
            {
                DateTime today = DateTime.Today;
                CultureInfo cultureDateTime = new CultureInfo("en-US");
                DateTime birthdayUser = Convert.ToDateTime(i_User.Birthday, cultureDateTime);
                int age = today.Year - birthdayUser.Year;
                today.AddYears(-age);
                if (DateTime.Compare(birthdayUser, today) > 0)
                {
                    age--;
                }

                if (age < i_MinAge || age > i_MaxAge)
                {
                    isMatch = false;
                }
            }

            return isMatch;
        }
    }
}
