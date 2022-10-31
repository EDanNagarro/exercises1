using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1.Section9
{
    internal class Exer11
    {
        interface IShootable
        {
            void Shoot();
        }
        public class Weapon
        {
            public string Name;
            public void Label()
            {
                Console.WriteLine("This is {0}!", Name);
            }
        }
        public class Gun : Weapon, IShootable
        {
            public Gun()
            {
                Name = "Gun";
            }

            public void Shoot()
            {
                Console.WriteLine("Bang!");
            }
        }

        public static class Program
        {
            static public void Run()
            {
                // new instance 
                Gun pist = new Gun();

                // test for methods
                pist.Label();
                pist.Shoot();

                // verifying the interface and the parent class
                if (pist is IShootable && pist is Weapon)
                    System.Console.WriteLine("Yes, it is my parents.");
            }
        }
    }
}
