using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencje
{
    class Program
    { 
    public static void ShowName(ref Computer personalComputer)
    {
            personalComputer = new Computer();
            personalComputer.name = "Moja nazwa";

        }

    
        static void Main(string[] args)
        {


            Computer myComputer = new Computer();

            Computer herComputer = myComputer;

            

            ShowName(ref myComputer);

            Console.WriteLine(myComputer.name + " wystąpienia " + Computer.wystapienia);
            Console.ReadKey();



        }
    }
}
