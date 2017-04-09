using IntervalsXamarinApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntervalsXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseViewPage
    {
        public ExerciseViewPage(IExercise exercise)
        {
            Title = $"{exercise.Name.ToUpper()}";
            Font.SystemFontOfSize(30, FontAttributes.Bold);

            var exDesc = new Label
            {
                Margin = new Thickness(10, 10, 0, 10),
                Text = $"Opis: {exercise.Description}"
            };

            var exTime = new Label
            {
                Margin = new Thickness(10, 10, 0, 10),
                Text = $"Czas trwania: {exercise.TimeLenght}."
            };

            var exImage = new Image
            {
                Margin = new Thickness(0, 10, 0, 10),
                Source = exercise.ExImage.UrlAdress,
                WidthRequest = exercise.ExImage.Width + 100,
                HeightRequest = exercise.ExImage.Height + 100
            };

            var startButton = new Button
            {
                Text = "Start!",
                FontAttributes = FontAttributes.Bold,
            };

            startButton.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new TraninigPage());
            };

            Content = new StackLayout
            {
                Children = { exImage, exDesc, exTime, startButton },
                BackgroundColor = Color.Gray
            };
        }
    }
}
