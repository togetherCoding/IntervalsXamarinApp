using Xamarin.Forms;

namespace IntervalsXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            

            ListView listView = new ListView();
            listView.ItemsSource = ExerciseBase.GetExercises();
            listView.ItemTemplate = new DataTemplate(typeof(ExerciseCell));
            Content = listView; 
        }
    }
}
