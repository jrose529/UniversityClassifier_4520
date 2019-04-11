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
        public static string sqlString = "server=uniclassifier.cdbytbcvrrjd.us-east-2.rds.amazonaws.com;database=tempdb;UID=masterusername;password=masterpassword";

        public int createAccount(string username, string fname, string lname, string emailaddr, string pw)
        {
            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                string query = "select username from [student] where username=@userName";

                using (SqlCommand checkUsernameCmd = new SqlCommand(query, connection))
                {
                    checkUsernameCmd.Parameters.AddWithValue("@username", username);

                    SqlDataAdapter dA = new SqlDataAdapter(checkUsernameCmd);
                    DataTable dT = new DataTable();
                    dA.Fill(dT);

                    if (dT.Rows.Count >= 1)
                    {
                        return 0; //This account already exists login
                    }
                }

                query = "insert into student (username,password,first_name,last_name,email) values (@username,@password,@firstname,@lastname,@emailAddress)";
               
                using (SqlCommand insertCmd = new SqlCommand(query, connection))
                {
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", pw);
                    insertCmd.Parameters.AddWithValue("@firstName", fname);
                    insertCmd.Parameters.AddWithValue("@lastName", lname);
                    insertCmd.Parameters.AddWithValue("@emailAddress", emailaddr);
                    
                    insertCmd.ExecuteNonQuery();

                    return 1; //Account made successfully
                }
            }
        }

        public int accountLogin(string username, string pw)
        {                 
            using (SqlConnection connection = new SqlConnection(sqlString))
            { 
                string query = "select username, password from [student] where username=@userName and password=@password";

                connection.Open();

                using (SqlCommand loginCmd = new SqlCommand(query, connection))
                {
                    loginCmd.Parameters.AddWithValue("@username", username);
                    loginCmd.Parameters.AddWithValue("@password", pw);

                    SqlDataAdapter dA = new SqlDataAdapter(loginCmd);
                    DataTable dT = new DataTable();
                    dA.Fill(dT);
                    if (dT.Rows.Count == 1)
                    {
                        return 1; //Correct login
                    }
                    else if (dT.Rows.Count == 0)
                    {
                        return 0; //Incorrect login
                    }
                    else
                    {
                        return 2; //More than one of the same information
                    }
                }
            }
        }

        public void updateAccount(string emailaddr, string pw, string currentAcct)
        {
            string queryBuilder = "";

            if (pw != "" && queryBuilder == "")
            {
                queryBuilder += "password = @password";
            }

            if (emailaddr != "" && queryBuilder != "")
            {
                queryBuilder += ",email = @emailAddress";
            }
            else if (emailaddr != "" && queryBuilder == "")
            {
                queryBuilder += "email = @emailAddress";
            }

            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                string query = "update student set " + queryBuilder + " where username = @username";
                
                connection.Open();

                using (SqlCommand updateCmd = new SqlCommand(query, connection))
                {
                    if (pw != "")
                    {
                        updateCmd.Parameters.AddWithValue("@password", pw);
                    }

                    if (emailaddr != "")
                    {
                        updateCmd.Parameters.AddWithValue("@emailAddress", emailaddr);
                    }

                    updateCmd.Parameters.AddWithValue("@username", currentAcct);

                    updateCmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            MessageBox.Show("SUCCESS: Information updated.");
        }
    }
}
