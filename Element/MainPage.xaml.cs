using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Element
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            Button Ent_btn = new Button
            {
                Text = "364",
                BackgroundColor = Color.Red
            };
            Button Timer_btn = new Button
            {
                Text = "346",
                BackgroundColor = Color.Fuchsia
            };
            StackLayout st = new StackLayout
            {
                Children = {Ent_btn, Timer_btn}
            };
            st.BackgroundColor = Color.Black;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_page());
        }        
        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_page());
        }
    }
}
