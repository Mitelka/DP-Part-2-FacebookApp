namespace FacebookApp
{   using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public class UserFacebookApp
    {
        public static AppId s_AppId;
        public User LoggedInUser { get; }

        private UserFacebookApp()
        {
            var result = FacebookService.Login(s_AppId.Value, "email", "user_likes", "user_photos", "user_posts",
                "user_birthday", "user_events", "user_friends", "public_profile");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
            }
            else
            {
                throw new LoggedInException(result.ErrorMessage);
            }
        }
    }
}
