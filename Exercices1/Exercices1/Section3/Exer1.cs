using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1.Section3
{
    internal class Exer1  
    {
        static public class Method
        {
            // Place for your methods
            public static string LowUpper(string input)
            {
                var stringInLower = input.ToLower();
                var stringInUpper = input.ToUpper();
                return stringInLower + stringInUpper;
            }
            public static void Count(string inputToCount)
            {
                var characterCount = inputToCount.Length;
                Console.WriteLine("The amount of characters is {0}.", characterCount);
            }

            public static void Run()
            {
                // We encourage you to test your code with different strings,
                // but don't forget to put the default string back at the end of your testing.
                string s = "HeY ThErE !";

                /// Change nothing down here 
                s = LowUpper(s);
                Console.WriteLine(s);
                Count(s);

            }
        }
    }
}