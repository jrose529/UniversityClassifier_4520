using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

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

            try
            {
                //database name, what table for sqlString + query
                string sqlString = "server=universitydatabase.cdbytbcvrrjd.us-east-2.rds.amazonaws.com;database=universitydatabase;UID=mdalonzo;password=masterpassword";
                string query = "select * from university";
                SqlConnection connection = new SqlConnection(sqlString);
                SqlCommand sqlCmd = new SqlCommand(query);
                connection.Open();
                DataSet dataSet = new DataSet();
                connection.Close();
                MessageBox.Show("connection possibly works");
                //display dataSet
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
            //open sql connection, verify these credentials. Use seperate sql class to open connection?
        }
    }
}
