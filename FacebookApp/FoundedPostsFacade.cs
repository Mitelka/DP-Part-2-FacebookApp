﻿namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public class FoundedPostsFacade
    {
        private FoundedPostsLogic m_FounedPostsLogic;

        public FoundedPostsFacade()
        {
            m_FounedPostsLogic = new FoundedPostsLogic();
        }

        public FacebookObjectCollection<Post> FindPostsByPattern(string i_Pattern, eResultTypes i_ResultType)
        {
            return m_FounedPostsLogic.FindPostsByPattern(i_Pattern, i_ResultType);
        }
    }
}
