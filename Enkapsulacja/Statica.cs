using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacja
{
    class Statica
    {

        public int test = 1;
        public static int id = 222;
        public static void IncInt()
        {
            id++;
        }

        public int Getid()
        {
            return id;
        }



    }
}
