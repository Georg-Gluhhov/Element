using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Element
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry_page : ContentPage
    {
        public Entry_page()
        {
            //InitializeComponent();
            StackLayout st = new StackLayout();
            Editor ed = new Editor
            {
                Placeholder = "Sisesta siis teksti",
                BackgroundColor = Color.Black,
                TextColor = Color.White,

            };
            Button tagasi = new Button
            {
                Text = "Tagasi"
            };
            tagasi.Clicked += Tagasi_Clicked;
            st.Children.Add(ed);
            st.BackgroundColor = Color.LightGray;
            Content = st;
        }

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}