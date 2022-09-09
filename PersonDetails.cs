using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOPracticeProblem
{
    public class PersonDetails
    {
        public void ReadFromStreamReader(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "C:C:\\BridgeLabs\\Phase 2\\FileIOPracticeProblem\\FileIOPracticeProblem\\Details.txt";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void WriteFromStreamWriter(string path)
        {
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Thank you");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}