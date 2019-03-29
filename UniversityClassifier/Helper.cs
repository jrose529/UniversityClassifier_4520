using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace UniversityClassifier
{
    public class Helper
    {
        public static string GetRDSConnectionString()
        {
        
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["software_engineering"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["mdalonzo"];
            string password = appConfig["masterpassword"];
            string hostname = appConfig["software-engineering.cdbytbcvrrjd.us-east-2.rds.amazonaws.com\n"];
            string port = appConfig["3306"];

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}
