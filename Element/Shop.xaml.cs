using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Element.boxView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Element
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shop : ContentPage
    {
        Button btn = new Button();
        Button btn2 = new Button();

        Label lbl = new Label();


        public Shop()
        {
            //Back button
            btn.Text = "BACK";
            btn.FontSize = 50;
            btn.BackgroundColor = Color.Black;
            btn.TextColor = Color.White;
            btn.Clicked += Btn_Clicked;

            //Mult button
            btn2.Text = "Buy mult: " + price.ToString();
            btn2.FontSize = 50;
            btn2.BackgroundColor = Color.Black;
            btn2.TextColor = Color.White;
            btn2.Clicked += Btn2_Clicked;

            //label
            lbl.Text = "Taps: " + taps.ToString();
            lbl.FontSize = 50;
            lbl.BackgroundColor = Color.Black;
            lbl.TextColor = Color.White;

            StackLayout st = new StackLayout { Children = { lbl, btn, btn2 } };
            Content = st;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            if (taps >= price)
            {
                taps = taps - price;
                price = price*2;
                mult += 1;
                lbl.Text = "Taps: " + taps.ToString();
                btn2.Text = "Buy mult: " + price.ToString();
            }
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new boxView());
        }
    }
}