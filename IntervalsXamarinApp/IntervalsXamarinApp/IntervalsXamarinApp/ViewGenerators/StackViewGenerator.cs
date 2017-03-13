using IntervalsXamarinApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntervalsXamarinApp.ViewOperation
{
    public class StackViewGenerator : IViewGenerator
    {
        private StackLayout _stackLayout;

        public StackViewGenerator(StackLayout stackLayout)
        {
            _stackLayout = stackLayout;
        }
        public void GenerateView(List<IExercise> dataToAdd)
        {
            foreach (IExercise ex in dataToAdd)
            {
                StackLayout horizontalStack = new StackLayout() { Orientation = StackOrientation.Horizontal, BackgroundColor = Color.Maroon };
                Label exName = new Label { Text = ex.Name, FontSize = 25, VerticalTextAlignment = TextAlignment.Center, FontAttributes = FontAttributes.Bold };
                Label exDescription = new Label { Text = $" - {ex.Description}", FontSize = 20, VerticalTextAlignment = TextAlignment.Center };
                var exImage = new Image
                {
                    WidthRequest = ex.ExImage.Width,
                    HeightRequest = ex.ExImage.Height,
                    Source = ImageSource.FromUri(new Uri(ex.ExImage.UrlAdress))
                };
                horizontalStack.Children.Add(exImage);
                horizontalStack.Children.Add(exName);
                horizontalStack.Children.Add(exDescription);
                _stackLayout.Children.Add(horizontalStack);
            }
        }
    }
}
