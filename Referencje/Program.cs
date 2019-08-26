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
           
            Arrays();

        }

        private static void Arrays()
        {

            Computer[] ratings = new Computer[4];
            AddRatings(ratings);

            foreach (Computer item in ratings)
            {
                Console.WriteLine(Computer.initCounter);
            }

            Console.WriteLine(ratings.Length);

            Console.ReadKey();

        }


        static void AddRatings(Computer[] ratings)
        {
            ratings[0] = new Computer();
            ratings[1] = new Computer();
            ratings[2] = new Computer();
            ratings[3] = new Computer();
        }


    }
}
