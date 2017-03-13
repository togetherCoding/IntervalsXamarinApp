﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalsXamarinApp.Infrastructure
{
    public interface IExercise
    {
        ExerciseImage ExImage { get; set; }
        TimeSpan TimeLenght { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
