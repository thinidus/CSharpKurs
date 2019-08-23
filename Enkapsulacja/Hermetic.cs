using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacja
{
    public class Hermetic
    {
        Computer komp = new Computer();

        public void AddData(string id)
        {
            komp.id = id;
        }

        public void Showdata()
        {
            Console.WriteLine("Identyfikator komputera: " + komp.id);
            Console.ReadKey();
        }

 

    }
}
