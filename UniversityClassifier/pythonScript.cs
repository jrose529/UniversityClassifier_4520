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
        public string runScript(uniQuery[] userAD, string[,] schoolInfo)
        {
            //string[,] report = new string[20, 2];
            string report;

            ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"pythonAlgo.txt");
            start.FileName = "C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\bin\\Debug\\GraduateAlgorithmFunction.exe";
            start.Arguments = string.Format("{0} {1} {2} {3} {4} {5} {6}", userAD[0].GRE, userAD[0].TOEFL, userAD[0].SoP, userAD[0].LoR, userAD[0].GPA, userAD[0].Research, schoolInfo);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    report = reader.ReadToEnd();
                }
            }
            return null;
        }
    }
}
