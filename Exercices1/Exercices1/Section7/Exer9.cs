using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1.Section7
{
    internal class Exer9
    {

            public static List<int> Solution()
            {
                // TODO: write your solution here
                var list = new List<int>();
                for (int i = 100; i < 171; i++)
                {
                    if (i % 2 == 0)
                    {
                        list.Add(i);
                    }

                }
                return list;

            }

        
    }
}
