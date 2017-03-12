using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntervalsXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var tapRecognizer = new TapGestureRecognizer();
            tapRecognizer.Tapped += (s, e) => { label1.Text = "zmieniono"; };

            stack.GestureRecognizers.Add(tapRecognizer);
        }
    }
}
