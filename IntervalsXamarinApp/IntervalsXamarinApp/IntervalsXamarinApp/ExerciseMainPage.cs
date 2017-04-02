using IntervalsXamarinApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntervalsXamarinApp
{
    public class ExerciseMainPage : ContentPage
    {
        public ExerciseMainPage()
        {
            var listView = new ListView();
            listView.ItemsSource = ExerciseBase.GetExercises();
            listView.ItemSelected += (s, e) =>
            {
                if(e.SelectedItem != null)
                {
                    //Navigation.PushAsync(new Page1(e.SelectedItem as IExercise));
                    Navigation.PushAsync(new ExerciseViewPage((listView.ItemsSource.Cast<IExercise>().First(x => x.Name.ToString() + x.Description.ToString() == e.SelectedItem.ToString()))));
                    Debug.WriteLine($"selected item is {e.SelectedItem}");
                }
                listView.SelectedItem = null;
            };
            listView.RowHeight = listView.ItemsSource.Cast<IExercise>().First().ExImage.Height;
            Title = "Interwaly!";
            listView.ItemTemplate = new DataTemplate(typeof(ExerciseCell));
            Content = listView;
        }
    }
}
