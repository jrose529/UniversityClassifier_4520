using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Reflection;


//this class reads the python script. It sends in arguments, user data and school info and 
//should return a 2d array with the school name and percent chance
namespace UniversityClassifier
{
    class pythonScript
    {
        public string[,] runScript(uniQuery[] userAD, string[,] schoolInfo)
        {
            string[,] report = new string[20, 2];

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"pythonAlgo.txt");
            start.Arguments = string.Format("{0} {1} {2} {3} {4} {5} {6}", userAD[0], userAD[1], userAD[2], userAD[3], userAD[4], userAD[5], schoolInfo);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    //report = reader.ReadToEnd();
                }
            }
            return null;
        }
    }
}
