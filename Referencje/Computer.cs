using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencje
{
    class Computer
    {
        public static int wystapienia;

        public Computer()
        {
            wystapienia++;
        }

        public string name = "Stara nazwa";

        public void Showname(string name)
        {
            Console.WriteLine(name);
        }


    }
}
