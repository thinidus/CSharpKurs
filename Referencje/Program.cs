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

        public delegate float Countme(float message);



        static void Main(string[] args)
        {

            Computer myComputer = new Computer();
            myComputer.NameChanged += new NameChangerDelegate(Onnamechange);
            myComputer.NameChanged += new NameChangerDelegate(OnnamechangeStars);
            myComputer.Name = "New";
            myComputer.costNett = 1000f;

            Countme countme = new Countme(myComputer.CountGross);





            WriteResult(myComputer.Name, countme(myComputer.costNett), 1f , 2f, 3.09f);

            myComputer.Name = "Całkiem nowa";



            Console.ReadKey();


        }

        private static void Onnamechange(string existingname, string newname)
        {
            Console.WriteLine($"Zmieniono z {existingname} na {newname}");
        }

        private static void OnnamechangeStars(string existingname, string newname)
        {
            Console.WriteLine(" \n * * * * * * * * * * * * * * * * * * * * * ");
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
