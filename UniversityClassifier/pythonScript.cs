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

namespace UniversityClassifier
{
    class pythonScript
    {
        public string runScript(uniQuery[] userAD, string[,] schoolInfo)
        {
            //string[,] report = new string[20, 2];
            string report;

            //ScriptEngine engine = Python.CreateEngine();
            //ScriptScope scope = engine.CreateScope();
            //string script = "C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\bin\\Debug\\GraduateAlgorithmFunction.exe";
;

            //engine.ExecuteFile(@"C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\bin\\Debug\\pythonAlgo.txt", scope);
            //engine.ExecuteFile(@"C:\\Users\\jensen\\Documents\\Visual Studio 2015\\Projects\\UniversityClassifier\\UniversityClassifier\\pythonScriptAlgo.py", scope);
            //dynamic testFunction = scope.GetVariable("graduate_algorithm");
            //var result = testFunction(userAD[0].GRE, userAD[0].TOEFL, userAD[0].SoP, userAD[0].LoR, userAD[0].GPA, userAD[0].Research, schoolInfo);


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

            /*string pythonInterp = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\\python.exe";
            string pythonScript = "pythonScriptAlgo.py";

            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(pythonInterp); 
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            //Check here that the arguments are formatted correctly
            myProcessStartInfo.Arguments = pythonScript + " " + string.Format("{0} {1} {2} {3} {4} {5} {6}", userAD[0].GRE, userAD[0].TOEFL, userAD[0].SoP, userAD[0].LoR, userAD[0].GPA, userAD[0].Research, schoolInfo);

            Process myProcess = new Process();
            // assign start information to the process 
            myProcess.StartInfo = myProcessStartInfo;

            // start process 
            myProcess.Start();

            StreamReader myStreamReader = myProcess.StandardOutput;
            string myString = myStreamReader.ReadLine();

            // wait exit signal from the app we called 
            myProcess.WaitForExit();

            // close the process 
            myProcess.Close();*/

            string schoolInfo_ = "";

            for (int i = 0; i < 1277; i++)
            {
                schoolInfo_ += schoolInfo[i, 0] + "," + schoolInfo[i, 1] + ",";
            }

            string progToRun = "C:\\Users\\jensen\\Desktop\\RunGraduateAlgorithm.py";
            char[] splitter = { '\r' };

            Process proc = new Process();
            proc.StartInfo.FileName = "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\Python37_64\\python.exe";
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;


            proc.StartInfo.Arguments = string.Concat(progToRun, " ", userAD[0].GRE.ToString(), " ", userAD[0].TOEFL.ToString(),
                                            " ", userAD[0].SoP.ToString(), " ", userAD[0].LoR.ToString(), " ",
                                            userAD[0].GPA.ToString(), " ", userAD[0].Research.ToString(), " ", schoolInfo_);
            proc.Start();

            StreamReader sReader = proc.StandardOutput;
            string[] output = sReader.ReadToEnd().Split(splitter);

            foreach (string s in output)
                Console.WriteLine(s);


            string algorithm_output = output[0];
            algorithm_output = algorithm_output.Split(new string[] { "Results:" }, StringSplitOptions.None)[1];



            string test = "";
            return test;
        }
    }
}
