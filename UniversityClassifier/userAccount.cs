using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UniversityClassifier
{
    class userAccount
    {
        string userName;
        string password;
        string emailAddr;
        string firstName;
        string lastName;

        public void createAccount(string username, string fname, string lname, string emailaddr, string pw)
        {
            userName = username;
            firstName = fname;
            lastName = lname;
            emailAddr = emailaddr;
            password = pw;

            //open sql connection, insert these credentials into database
        }

        public void accountLogin(string username, string pw)
        {
            userName = username;
            password = pw;

            //open sql connection, verify these credentials. Use seperate sql class to open connection?
        }

    }
}
