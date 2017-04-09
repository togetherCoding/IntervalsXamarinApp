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
    public partial class EntrancePage : ContentPage
    {
        public EntrancePage()
        {
            InitializeComponent();
            Title = "Witamy w aplikacji interwalowej!";
            var navigateToExercisePage = new Button
            {
                Text = "Lista cwiczen",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Fill,
                Margin = new Thickness(20, 20, 20, 0)
            };

            navigateToExercisePage.Clicked += (o, e) => Navigation.PushAsync(new ExerciseMainPage());
            Content = new StackLayout
            {
                Children = { navigateToExercisePage }
            };
        }
    }
}
