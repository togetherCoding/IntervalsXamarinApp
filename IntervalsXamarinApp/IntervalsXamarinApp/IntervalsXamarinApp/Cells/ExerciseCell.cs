using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntervalsXamarinApp
{
    public class ExerciseCell : ViewCell
    {
        public ExerciseCell()
        {
            var nameLabel = new Label()
            {
                FontSize = 35,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
            };
            nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));

            var descriptionLabel = new Label()
            {
                FontSize = 15,
                TextColor = Color.Black,
            };
            descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));

            var exImage = new Image
            {
                Margin = new Thickness(5, 5, 0, 5)
            };
            exImage.SetBinding(Image.SourceProperty, new Binding("ExImage.UrlAdress"));

            View = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    exImage,
                    new StackLayout()
                    {
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Spacing = 0,
                        Children =
                        {
                            nameLabel,
                            descriptionLabel
                        },
                    }
                },
                BackgroundColor = Color.Gray,
            };
        }
    }
}

