namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string url = "https://cataas.com/cat";
            string s = entTekst.Text;
            if (!string.IsNullOrEmpty(s))
            {
                url += "/says/" + s;
            }

            imgCat.Source = url;
        }

      
        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
        
            double newSize = e.NewValue;
            imgCat.HeightRequest = newSize;  
            imgCat.WidthRequest = newSize;   
        }
    }
}
