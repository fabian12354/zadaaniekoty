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
                if (entTekst.Text != null && s.Length > 0)
                    url += "/says/" + s;

                imgCat.Source = url;
            }
        }

    

}
