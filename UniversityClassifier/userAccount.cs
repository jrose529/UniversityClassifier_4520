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


            string sqlString = "server=software-engineering.cdbytbcvrrjd.us-east-2.rds.amazonaws.com;database=software_engineering;UID=mdalonzo;password=masterpassword";

            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                string query = "insert into user (username,password,first_name,last_name) values (@username,@password,@firstname,@lastname)";
                using (SqlCommand insertCmd = new SqlCommand(query, connection))
                {
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.Parameters.AddWithValue("@firstName", firstName);
                    insertCmd.Parameters.AddWithValue("@lastName", lastName);

                
                    connection.Open();

                    int affectedRows = insertCmd.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show(affectedRows + " rows inserted!");
                }
            }
        }

        public void accountLogin(string username, string pw)
        {
            userName = username;
            password = pw;

            /*SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=software-engineering.cdbytbcvrrjd.us-east-2.rds.amazonaws.com;" +
            "Initial Catalog=software_engineering;" +
            "User id=mdalonzo;" +
            "Password=masterpassword;";
            conn.Open();
            string query = "select * from university";
            SqlCommand sqlCmd = new SqlCommand(query);
            DataSet dataSet = new DataSet();
            conn.Close();
            MessageBox.Show("connection possibly works");*/
            try
            {
                string sqlString = "Server=software-engineering.cdbytbcvrrjd.us-east-2.rds.amazonaws.com;database=software_engineering;UID=mdalonzo;password=masterpassword";
                string sqlString_ = "Server=uniclassifier.cdbytbcvrrjd.us-east-2.rds.amazonaws.com;database=uniclassifier;UID=masterusername;Password=masterpassword";
                string sqlString__ = "Data Source=software-engineering.cdbytbcvrrjd.us-east-2.rds.amazonaws.com;Network Library = DBMSSOCN; Initial Catalog=software_engineering; User ID = mdalonzo; Password = masterpassword";
                string query = "select username,password from user where username=userName and password=password";

                //string query = "select username, password " +
                //"from user " +
                //"where username=userName " +
                //"and password=password";

                SqlConnection connection = new SqlConnection(sqlString__);
                connection.Open();
                SqlCommand sqlCmd = new SqlCommand(query);
                DataSet dataSet = new DataSet();
                connection.Close();
                MessageBox.Show("connection possibly works");
                //display dataSet
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
    }
}
