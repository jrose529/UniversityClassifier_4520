using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

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

            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            //string script = "C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\bin\\Debug\\GraduateAlgorithmFunction.exe";
;

            engine.ExecuteFile(@"C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\bin\\Debug\\pythonAlgo.txt", scope);
            //engine.ExecuteFile(@"C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\pythonScriptAlgo.py", scope);
            dynamic testFunction = scope.GetVariable("graduate_algorithm");
            var result = testFunction(userAD[0].GRE, userAD[0].TOEFL, userAD[0].SoP, userAD[0].LoR, userAD[0].GPA, userAD[0].Research, schoolInfo);


            /*ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = "C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\bin\\Debug\\GraduateAlgorithmFunction.py";
            start.FileName = "C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\pythonAlgo.txt";

            start.Arguments = string.Format("{0} {1} {2} {3} {4} {5} {6}", userAD[0].GRE, userAD[0].TOEFL, userAD[0].SoP, userAD[0].LoR, userAD[0].GPA, userAD[0].Research, schoolInfo);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd();
                    report = reader.ReadToEnd();
                }
            }*/
            string test = "";
            return test;
        }
    }
}
