using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1.Section7
{
    internal class Exer10
    {
        
            public static string Convert(int i)
            {
                // TODO
                Dictionary<int, string> dic = new Dictionary<int, string>(){
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"}
            };

                if (dic.ContainsKey(i))
                    return dic[i];
                else
                    return "nope";
            }
        
    }
}
