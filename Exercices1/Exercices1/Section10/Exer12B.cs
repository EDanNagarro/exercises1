using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1.Section10
{
    internal class Exer12B
    {
        public static void Run()
        {
            string path = @"\Users\eliudsantillan\Documents\GitHub\exercises1\Exercices1\Exercices1\Section10\input.txt";
            string outpath = @"\Users\eliudsantillan\Documents\GitHub\exercises1\Exercices1\Exercices1\Section10\output.txt";
            
            string[] textLines = System.IO.File.ReadAllLines(path);
            using (StreamWriter file = new StreamWriter(outpath))
            {
                foreach (string line in textLines)
                {
                    if (line.Contains("split") == true)
                    {
                        string[] split = line.Split(" ");
                        string toBeWritten = split[4] + " ";
                        Console.WriteLine(toBeWritten);
                        file.Write(toBeWritten);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
