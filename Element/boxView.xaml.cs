using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Element.Shop;

namespace Element
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class boxView : ContentPage
    {
        Label lbl = new Label();
        Button btn = new Button();
        public static BoxView box = new BoxView();
        public static int price = 10;        
        public static int price2x = 100;
        public static int taps = 0;
        public static int mult = 0;
        public static int red = 0;
        public static int green = 0;
        public static int blue = 0; 
        public static int x2 = 1;
        public boxView()
        {

            //label
            lbl.Text = "Taps: " + taps.ToString();
            lbl.FontSize = 50;
            lbl.BackgroundColor = Color.Black;
            lbl.TextColor = Color.White;

            //Shop button
            btn.Text = "SHOP";
            btn.FontSize = 50;
            btn.BackgroundColor = Color.Black;
            btn.TextColor = Color.White;
            btn.Clicked += Btn_Clicked;


            box.Color = Color.FromRgb(red,green,blue);
            box.CornerRadius = 180;
            box.WidthRequest = 300;
            box.HeightRequest = 300;
            box.HorizontalOptions = LayoutOptions.Center;
            box.VerticalOptions = LayoutOptions.CenterAndExpand;

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);


            StackLayout st = new StackLayout { Children = { lbl,btn, box }};
            Content = st;
            
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shop());
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            taps += 1+mult*2;
            lbl.Text = "Taps: " + taps.ToString();

        }
    }
}