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
        Button btn3 = new Button();
        Button btn4 = new Button();
        Button btn5 = new Button();
        Button btn6 = new Button();
        Button btn7 = new Button();

        Label lbl = new Label();
        Label lbl2 = new Label();


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
            //2x button
            btn7.Text = "Buy x2: " + (price2x).ToString();
            btn7.FontSize = 50;
            btn7.BackgroundColor = Color.Black;
            btn7.TextColor = Color.White;
            btn7.Clicked += BuyX2; ;

            //label
            lbl.Text = "Taps: " + taps.ToString();
            lbl.FontSize = 50;
            lbl.BackgroundColor = Color.Black;
            lbl.TextColor = Color.White;

            //rgb

            //red
            btn3.Text = "Buy Red";
            btn3.FontSize = 50;
            btn3.BackgroundColor = Color.Black;
            btn3.TextColor = Color.White;
            btn3.Clicked += BuyRed;
            //green
            btn4.Text = "Buy Green";
            btn4.FontSize = 50;
            btn4.BackgroundColor = Color.Black;
            btn4.TextColor = Color.White;
            btn4.Clicked += BuyGreen; ;
            //blue
            btn5.Text = "Buy Blue";
            btn5.FontSize = 50;
            btn5.BackgroundColor = Color.Black;
            btn5.TextColor = Color.White;
            btn5.Clicked += BuyBlue; ;
            //Reset
            btn6.Text = "Reset Colors";
            btn6.FontSize = 50;
            btn6.BackgroundColor = Color.Black;
            btn6.TextColor = Color.White;
            btn6.Clicked += ResetColors; ;
            //pre
            lbl2.Text = "";
            lbl2.FontSize = 50;
            lbl2.BackgroundColor = Color.FromRgb(red, green, blue); 

            StackLayout st = new StackLayout { Children = { lbl, btn, btn2, btn7, btn3, btn4, btn5, btn6, lbl2} };
            Content = st;
        }

        private void BuyX2(object sender, EventArgs e)
        {
            if (taps >= price2x)
            { 
            taps = taps - price2x;
            price2x = price2x * 5;
            x2 *= 1;
            lbl.Text = "Taps: " + taps.ToString();
            btn7.Text = "Buy x2: " + price2x.ToString();
            }
        }

        private void ResetColors(object sender, EventArgs e)
        {
            green=0; 
            red = 0; 
            blue = 0;
            lbl2.BackgroundColor = Color.FromRgb(red, green, blue);
        }

        private void BuyGreen(object sender, EventArgs e)
        {

            green += 10;
            lbl2.BackgroundColor = Color.FromRgb(red, green, blue);
        }

        private void BuyBlue(object sender, EventArgs e)
        {
            blue += 10;
            lbl2.BackgroundColor = Color.FromRgb(red, green, blue);
        }

        private void BuyRed(object sender, EventArgs e)
        {
            red += 10;
            lbl2.BackgroundColor = Color.FromRgb(red, green, blue);
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