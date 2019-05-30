using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {

            Diary diary = new Diary();

            //diary.AddRating(5);
            //diary.AddRating(8.5F);
            //diary.AddRating(4.7f);


            //float avg = diary.CaculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ;)
            {
            
                Console.WriteLine("Podaj ocenę z zakresu 1- 10");
                float rating;
                bool resultOfParse = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 11)
                {
                    break;
                }

                if (resultOfParse == true)
                {
                    if (rating <= 11 && rating >= 1 )
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Podałeś liczbę z poza zakresu.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Wprowadziłeś niepoprawny znak");
                }

                

                


            }

            Console.WriteLine("Średnia ocen: "+ diary.CaculateAverage());
            Console.WriteLine("Najwyższa ocena: " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena: " + diary.GiveMinRating());


            Console.ReadKey();
            

        }
    }
}
