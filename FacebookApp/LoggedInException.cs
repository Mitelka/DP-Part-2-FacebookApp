namespace FacebookApp
{
    using System;

    public class LoggedInException : Exception
    {
        public LoggedInException() : base()
        {
        }

        public LoggedInException(string i_Message) : base(i_Message)
        {
        }

        public LoggedInException(string i_Message, Exception i_InnerException) : base(i_Message, i_InnerException)
        {
        }
    }
}
