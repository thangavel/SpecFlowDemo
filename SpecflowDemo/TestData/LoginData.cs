using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowDemo.TestData
{
    class LoginData
    {
        private static readonly string _userName = ConfigurationManager.AppSettings["UserName"].ToString();
        public static string UserName
        {
            get { return _userName; }
        }


        private static readonly string _passWord = ConfigurationManager.AppSettings["PassWord"].ToString();
        public static string PassWord
        {
            get { return _passWord; }
        }


        private static readonly string _url = ConfigurationManager.AppSettings["URL"].ToString();
        public static string URL
        {
            get { return _url; }
        }
    }
}
