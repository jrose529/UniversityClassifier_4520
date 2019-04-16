using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace UniversityClassifier
{
    class uniQuery : UCMain
    {
        public static string sqlString = "server=uniclassifier.cdbytbcvrrjd.us-east-2.rds.amazonaws.com;database=tempdb;UID=masterusername;password=masterpassword";
        public double GRE { get; set; }
        public double TOEFL { get; set; }
        public double SoP { get; set; }
        public double LoR { get; set; }
        public double GPA { get; set; }
        public double Research { get; set; }

        public int getCurrentAcctIndex(string currentAcct)
        {
            int studentIndex;

            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                string query = "select pid from student where username = @userName";

                connection.Open();

                using (SqlCommand getIndexCmd = new SqlCommand(query, connection))
                {
                    getIndexCmd.Parameters.AddWithValue("@userName", currentAcct);

                    studentIndex = (Int32)getIndexCmd.ExecuteScalar();
                }
            }
                return studentIndex;
        }

        public void insertAcademicData(string currentAcct, string GPA, string GRE, string TOEFL, string SoP, string LoR, bool research)
        {
            int studentIndex = getCurrentAcctIndex(currentAcct);

            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                connection.Open();

                string query = "insert into academicData (gre,toefl,SOP,LOR,CGPA,research,pid_fk) values (@GRE,@TOEFL,@SoP,@LoR,@GPA,@research,@pid_fk)";

                using (SqlCommand insertCmd = new SqlCommand(query, connection))
                {
                    insertCmd.Parameters.AddWithValue("@GRE", Int32.Parse(GRE));
                    insertCmd.Parameters.AddWithValue("@TOEFL", Int32.Parse(TOEFL));
                    insertCmd.Parameters.AddWithValue("@SoP", (float)Convert.ToDouble(SoP));
                    insertCmd.Parameters.AddWithValue("@LoR", (float)Convert.ToDouble(LoR));
                    insertCmd.Parameters.AddWithValue("@GPA", (float)Convert.ToDouble(GPA));
                    insertCmd.Parameters.AddWithValue("@research", Convert.ToInt32(research));
                    insertCmd.Parameters.AddWithValue("@pid_fk", studentIndex);

                    insertCmd.ExecuteNonQuery();
                }
            }
        }


        public void universityQuery(string currentAcct, string uniName)
        {
            string uniName_noSpaces = Regex.Replace(uniName, " ", "");
            int studentIndex;
            uniQuery[] userAD = null;
            uniQuery[] schoolAD = null;

            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                connection.Open();

                string query = "select gre,toefl,sop,lor,cgpa from university where school = @schoolName";

                using (SqlCommand uniCmd = new SqlCommand(query, connection))
                {
                    uniCmd.Parameters.AddWithValue("@schoolName", uniName_noSpaces);

                    using (SqlDataReader reader = uniCmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("ERROR: Invalid School Name");
                            return;
                        }

                        var listAD = new List<uniQuery>();
                        while (reader.Read())
                        {
                            listAD.Add(new uniQuery
                            {
                                GRE = reader.GetDouble(0),
                                TOEFL = reader.GetDouble(1),
                                SoP = reader.GetDouble(2),
                                LoR = reader.GetDouble(3),
                                GPA = reader.GetDouble(4)
                            });

                        }
                        schoolAD = listAD.ToArray();
                    }
                }

                studentIndex = getCurrentAcctIndex(currentAcct);
                query = "select gre,toefl,sop,lor,cgpa from academicData where pid_fk = @studentIndex";

                using (SqlCommand userADCmd = new SqlCommand(query, connection))
                {
                    userADCmd.Parameters.AddWithValue("@studentIndex", studentIndex);

                    using (SqlDataReader reader = userADCmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("ERROR: User Has No Stats");
                            return;
                        }

                        var listUserAD = new List<uniQuery>();
                        while (reader.Read())
                        {
                            listUserAD.Add(new uniQuery
                            {
                                GRE = (double)reader.GetInt64(0),
                                TOEFL = (double)reader.GetInt64(1),
                                SoP = reader.GetDouble(2),
                                LoR = reader.GetDouble(3),
                                GPA = reader.GetDouble(4)
                            });
                        }

                        userAD = listUserAD.ToArray();
                    }
                }
            }

            MessageBox.Show("           Student        University\n"
                            + "GRE       " + userAD[0].GRE + "               " + schoolAD[0].GRE
                            + "\nTOEFL    " + userAD[0].TOEFL + "               " + schoolAD[0].TOEFL
                            + "\nGPA         " + userAD[0].GPA + "                    " + schoolAD[0].GPA
                            + "\nSoP         " + userAD[0].SoP + "                    " + schoolAD[0].SoP
                            + "\nLoR         " + userAD[0].LoR + "                    " + schoolAD[0].LoR, "Results");
        }

        public void generateReport(string currentAcct)
        { 
            int studentIndex;
            uniQuery[] userAD = null;
            string[,] schoolInfo = new string[1277, 2];
            //string[,] report = new string[20, 2];
            string report;

            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                studentIndex = getCurrentAcctIndex(currentAcct);

                connection.Open();

                string query = "select gre,toefl,SOP,LOR,CGPA,Research from academicData where pid_fk = @studentIndex";

                using (SqlCommand getADCmd = new SqlCommand(query, connection))
                {
                    getADCmd.Parameters.AddWithValue("@studentIndex", studentIndex);

                    using (SqlDataReader reader = getADCmd.ExecuteReader())
                    {
                        var listAD = new List<uniQuery>();
                        while (reader.Read())
                        {
                            listAD.Add(new uniQuery { GRE = reader.GetInt64(0),
                                                      TOEFL = reader.GetInt64(1),
                                                      SoP = reader.GetDouble(2),
                                                      LoR = reader.GetDouble(3),
                                                      GPA = reader.GetDouble(4),
                                                      Research = reader.GetInt64(5)});

                        }
                        userAD = listAD.ToArray();
                    }
                }

                query = "select school,average from university";

                using (SqlCommand getSchoolInfoCmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = getSchoolInfoCmd.ExecuteReader())
                    {
                        var listSchoolInfo = new List<schoolNamesRanks>();
                        while (reader.Read())
                        {
                            listSchoolInfo.Add(new schoolNamesRanks
                            { schoolName = reader.GetString(0), avgRanking = reader.GetInt64(1) });

                        }
                        
                        int count = 0;
                        foreach (var listObj in listSchoolInfo)
                        {
                            schoolInfo[count,0] = listObj.schoolName;
                            schoolInfo[count,1] = Convert.ToString(listObj.avgRanking);
                            count++;  
                        }

                        pythonScript generateReport = new pythonScript();
                        report = generateReport.runScript(userAD, schoolInfo);
                    }
                }


                //pull academic data then push that into python. Add chance of admissions to table 
            }
        }
    }
}
