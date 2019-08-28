using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Referencje
{
    class Program
    { 
    
        static void Main(string[] args)
        {

            Computer myComputer = new Computer();

            myComputer.name = "Pentium";
            myComputer.costNett = 1000f;

            WriteResult(myComputer.name, myComputer.CountGross(myComputer.costNett));

            Console.ReadKey();


        }

       static void WriteResult(string name, float gross)
        {
            Console.WriteLine(name + ": " + gross + " brutto");
        }

        static void WriteResult(string name, int gross)
        {
            Console.WriteLine(name + ": " + gross + " brutto");
        }



    }
}
