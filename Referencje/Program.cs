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

            myComputer.Name = "";
            myComputer.costNett = 1000f;

            WriteResult(myComputer.Name, myComputer.CountGross(myComputer.costNett), 1f , 2f, 3.09f);

            Console.ReadKey();


        }

       static void WriteResult(string Name, params float[] gross)
        {
            Console.WriteLine($"{Name}: {gross[0]:C2} brutto[float] {gross.Length}");
                
        }

        static void WriteResult(string Name, int gross)
        {
            Console.WriteLine(Name + ": " + gross + " brutto");
        }



    }
}
