﻿using IntervalsXamarinApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalsXamarinApp
{
    public class ExerciseBase
    {
        public static List<IExercise> GetExercises()
        {
            return new List<IExercise>()
            {
                 new Exercise { Name = "hardkor", Description = "nie dasz rady", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = @"http://lorempixel.com/300/200/people/1" }},
                 new Exercise { Name = "masakra", Description = "spocisz sie", TimeLenght = TimeSpan.FromMinutes(60),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = @"http://lorempixel.com/300/200/people/4" }},
                 new Exercise { Name = "smierc", Description = "uciekaj", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = $"http://lorempixel.com/300/200/people/3" }},
                 new Exercise { Name = "jazda", Description = "nie dasz rady", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = @"http://lorempixel.com/300/200/people/2" }},
                 new Exercise { Name = "trojkat", Description = "spocisz sie", TimeLenght = TimeSpan.FromMinutes(60),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = @"http://lorempixel.com/300/200/people/5" }},
                 new Exercise { Name = "gwiazda", Description = "uciekaj", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = $"http://lorempixel.com/300/200/people/6" }},
                 new Exercise { Name = "Moze kardio?", Description = "nie dasz rady", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = @"http://lorempixel.com/300/200/people/7" }},
                 new Exercise { Name = "Klatka i biceps", Description = "spocisz sie", TimeLenght = TimeSpan.FromMinutes(60),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = @"http://lorempixel.com/300/200/people/8" }},
                 new Exercise { Name = "Po co komu radio?", Description = "uciekaj", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 150, Width = 200, UrlAdress = $"http://lorempixel.com/300/200/people/9" }}
            };
        }
    }
}
