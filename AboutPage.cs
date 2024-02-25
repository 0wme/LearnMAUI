using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace LearnMAUI
{
    public class AboutPage : ContentPage
    {
        public AboutPage()
        {
            Content = new Label
            {
                Text = "About Page",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Colors.Black
            };
        }
    }
}