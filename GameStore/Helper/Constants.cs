using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GameStore.Helper
{
    public class Constants
    {
        public static string UserImagePath
        {
            get { return ConfigurationManager.AppSettings["ImagePath"]; }
        }
    }
}