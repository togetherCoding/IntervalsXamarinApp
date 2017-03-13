﻿using IntervalsXamarinApp.Infrastructure;
using IntervalsXamarinApp.ViewOperation;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IntervalsXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var exerciseList = new List<IExercise>()
            {
                 new Exercise { Name = "hardkor", Description = "nie dasz rady", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = @"http://lorempixel.com/300/200/people/1" }},
                 new Exercise { Name = "masakra", Description = "spocisz sie", TimeLenght = TimeSpan.FromMinutes(60),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = @"http://lorempixel.com/300/200/people/4" }},
                 new Exercise { Name = "smierc", Description = "uciekaj", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = $"http://lorempixel.com/300/200/people/3" }},
                 new Exercise { Name = "hardkor", Description = "nie dasz rady", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = @"http://lorempixel.com/300/200/people/2" }},
                 new Exercise { Name = "masakra", Description = "spocisz sie", TimeLenght = TimeSpan.FromMinutes(60),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = @"http://lorempixel.com/300/200/people/5" }},
                 new Exercise { Name = "smierc", Description = "uciekaj", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = $"http://lorempixel.com/300/200/people/6" }},
                 new Exercise { Name = "hardkor", Description = "nie dasz rady", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = @"http://lorempixel.com/300/200/people/7" }},
                 new Exercise { Name = "masakra", Description = "spocisz sie", TimeLenght = TimeSpan.FromMinutes(60),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = @"http://lorempixel.com/300/200/people/8" }},
                 new Exercise { Name = "smierc", Description = "uciekaj", TimeLenght = TimeSpan.FromMinutes(80),
                     ExImage = new ExerciseImage { Height = 50, Width = 50, UrlAdress = $"http://lorempixel.com/300/200/people/9" }}
            };
            IViewGenerator generate = new StackViewGenerator(stack);
            generate.GenerateView(exerciseList);
     
            //var tapRecognizer = new TapGestureRecognizer();
            //tapRecognizer.Tapped += (s, e) => { label.Text = "zmieniono"; };

            //element1.GestureRecognizers.Add(tapRecognizer);
        }
    }
}
