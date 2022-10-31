using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1.Section7
{
    internal class Exer7
    {
        public static void GetOdd(int[] Array)
        {
            // TODO
            foreach (int x in Array)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                };
            };
        }

        public static void GetEven(int[] Array)
        {
            // TODO
            foreach (int x in Array)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                };
            };
        }

        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);

        }
    }
}
