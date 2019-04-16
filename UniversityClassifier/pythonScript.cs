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
            string schoolInfo_ = "";

            for (int i = 0; i < 200; i++)
            {
                schoolInfo_ += schoolInfo[i, 0] + "," + schoolInfo[i, 1] + ",";
            }

            string progToRun = "C:\\Users\\jensen\\Desktop\\RunGraduateAlgorithm.py";
            char[] splitter = { '\r' };

            Process proc = new Process();
            proc.StartInfo.FileName = "python.exes";
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
