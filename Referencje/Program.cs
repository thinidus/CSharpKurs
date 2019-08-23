using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencje
{
    class Program
    { 
    
        static void Main(string[] args)
        {
            Immutable();

        }

        private static void Immutable()
        {

            string name = " Marcin ";
            name = name.Trim();

            DateTime date = new DateTime(2015 , 3 , 10);
            date = date.AddHours(48);

            Computer computer = new Computer();
            

            Console.WriteLine(date);
            Console.ReadKey();
            
        }
    }
}
