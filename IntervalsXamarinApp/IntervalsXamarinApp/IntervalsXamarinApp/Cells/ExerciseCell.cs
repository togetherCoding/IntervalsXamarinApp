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
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                XAlign = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));

            var descriptionLabel = new Label()
            {
                Font = Font.SystemFontOfSize(NamedSize.Small),
                VerticalTextAlignment = TextAlignment.Center
            };
            descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));

            var exImage = new Image
            {
                
                WidthRequest = 50,
                HeightRequest = 50
            };
            exImage.SetBinding(Image.SourceProperty, new Binding("ExImage.UrlAdress"));


            View = new StackLayout
            {
                Children = {exImage, nameLabel, descriptionLabel },
                Orientation = StackOrientation.Horizontal 
            };

        }
    }
}
