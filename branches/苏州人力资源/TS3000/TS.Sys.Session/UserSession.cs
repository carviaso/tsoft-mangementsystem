using System;
using System.Collections.Generic;
using System.Text;

namespace TS.Sys.Session
{
    public class UserSession
    {
        private static string _userid;
        private static DateTime _loginDate;

        public static string UserID
        {
            get { return "1"; }//_userid;}
            set { _userid = value;}
        }

        public static DateTime LoginDate
        {
            get { return DateTime.Today; }// _loginDate; }
            set { _loginDate = value; }
        }
    }
}
