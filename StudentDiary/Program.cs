using System;


namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            void changeName(Diary diary)
            {
                diary = new Diary();
                diary.nazwa = "Artura dziennik";
            }


            diary.AddRating(5);
            diary.AddRating(8.5F);
            diary.AddRating(4.7f);
            diary.AddRating(1.7f);
            diary.AddRating(5);
            diary.AddRating(1);

            DiaryStatistics stats = diary.ComputeStatistics();

            Console.WriteLine("średnia: " + stats.avgaverageGrade);
            Console.WriteLine("Max: " + stats.maxGrade);
            Console.WriteLine("Min: " + stats.minGrade);

            Diary diary2 = new Diary();

            diary2.AddRating(1.7f);
            diary2.AddRating(5);
            diary2.AddRating(1);

            stats = diary2.ComputeStatistics();

            Console.WriteLine("średnia2: " + stats.avgaverageGrade);
            Console.WriteLine("Max2: " + stats.maxGrade);
            Console.WriteLine("Min2: " + stats.minGrade);




            Console.ReadKey();
            

        }
    }
}
