﻿using System;
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


        //Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CaculateAverage()
        {
            float sum = 0;
            float average = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            average = sum / ratings.Count();
            return average;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }


    }
}
