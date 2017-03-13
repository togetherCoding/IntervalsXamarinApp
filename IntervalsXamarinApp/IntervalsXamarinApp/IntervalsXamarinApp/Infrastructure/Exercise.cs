using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalsXamarinApp.Infrastructure
{
    public class Exercise : IExercise
    {
        public ExerciseImage ExImage { get; set; }
        public TimeSpan TimeLenght { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Exercise() 
        {
        }
    }
}
