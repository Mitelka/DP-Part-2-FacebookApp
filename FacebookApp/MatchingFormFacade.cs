using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    using static FacebookWrapper.ObjectModel.User;

    public class MatchingFormFacade
    {
        private MatchingFormLogic m_MatchingFormLogic;

        public MatchingFormFacade()
        {
            m_MatchingFormLogic = new MatchingFormLogic();
        }

        public string GetProfilePicUrl()
        {
            return m_MatchingFormLogic.GetProfilePicUrl();
        }

        public List<User> FindMatches(eGender i_Gender, int i_MinAge, int i_MaxAge)
        {
            return m_MatchingFormLogic.FindMatches(i_Gender, i_MinAge, i_MaxAge);
        }
    }
}
