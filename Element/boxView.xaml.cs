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
    public partial class boxView : ContentPage
    {
        Label lbl = new Label();
        Button btn = new Button();

        public static int taps = default;
        public static int mult = default;
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

            BoxView box = new BoxView
            {
                Color = Color.Blue,
                CornerRadius = 180,
                WidthRequest = 300,
                HeightRequest = 300,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

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
            taps += 1;
            int all = taps + mult;
            lbl.Text = "Taps: " + all.ToString();
        }
    }
}