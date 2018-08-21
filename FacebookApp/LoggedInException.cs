namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

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
