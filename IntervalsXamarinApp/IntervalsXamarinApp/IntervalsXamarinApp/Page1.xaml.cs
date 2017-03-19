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
    public partial class Page1 : ContentPage
    {
        public Page1(IExercise exercise)
        {
            Title = $"Wybrales interwal - {exercise.Name.ToUpper()}";
            Font.SystemFontOfSize(30, FontAttributes.Bold);
            var exName = new Label()
            {
                Text = $"Nazwa: {exercise.Name}"
            };
            var exDesc = new Label()
            {
                Text = $"Opis: {exercise.Description}"
            };
            var exTime = new Label()
            {
                Text = $"Czas trwania: {exercise.TimeLenght}"
            };
            var exImage = new Image()
            {
                Source = exercise.ExImage.UrlAdress,
                WidthRequest = exercise.ExImage.Width,
                HeightRequest = exercise.ExImage.Height
            };
            Content = new StackLayout
            {
                Children = { exImage, exName, exDesc, exTime }
            };
        }
    }
}
