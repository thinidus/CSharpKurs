using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacja
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hermetic compinfo = new Hermetic();
            //string id;

            //Console.WriteLine("Podaj id:");
            //compinfo.AddData(Console.ReadLine());
            //compinfo.Showdata();



            Statica statica = new Statica();

            Statica.id++;

            Console.WriteLine(statica.Getid());
            Console.ReadKey();

            Statica alias = statica;
            Console.WriteLine(alias.Getid());
            Console.ReadKey();


            Statica.id++;


            Console.WriteLine(statica.Getid());
            Console.ReadKey();

            
            Console.WriteLine(alias.Getid());
            Console.ReadKey();





        }
    }
}
