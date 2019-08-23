using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {



            void ChangeName(ref Obiekt nazwaobiektu)
            {
                nazwaobiektu = new Obiekt();
                nazwaobiektu.nazwa = "nowa nazwa";
            }

            Obiekt newObiekt = new Obiekt();

            

            Obiekt najnowszy = newObiekt;

            ChangeName(ref najnowszy);





            Console.WriteLine(najnowszy.nazwa + " - " + najnowszy.wystapienia + " - " + najnowszy.nazwa.GetType());





            Console.ReadKey();


        }
    }
}
