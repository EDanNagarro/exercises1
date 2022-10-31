using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1.Section5
{
    internal class Exer5
    {
        public static void ForLoop()
        {
            // TODO
            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            // TODO
            int Counter = 3;
            while (Counter >= -3)
            {
                Console.WriteLine(Counter);
                Counter--;
            }
        }

        public static void Run1()
        {
            WhileLoop();
            ForLoop();

        }


        public static void Run2()
        {
            int i = -10;

            while (i < 10 == true)
            {

                // TODO
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i++);
            }
        }


    }
}

