using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        //Stan - zmienne - pola
        List<float> ratings;

        public string nazwa;


        //Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        internal DiaryStatistics ComputeStatistics()
        {

            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.avgaverageGrade = sum / ratings.Count();
            stats.maxGrade = ratings.Max();
            stats.minGrade = ratings.Min();

            return stats;
        }



    }
}
