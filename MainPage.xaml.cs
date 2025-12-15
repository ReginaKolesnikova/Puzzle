using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;


namespace Puzzle
{
    public partial class MainPage : ContentPage
    {
        public List<ContentPage> lehed = new List<ContentPage>() 
        {
            new GaleryPage(),  
            new SeadedPage(), 
            new ReeglidPage()  
        };

        public List<string> tekstid = new List<string>()  
        {
            "Mängi",  
            "Seaded", 
            "Reeglid"
        };

        VerticalStackLayout vsl;  
        ScrollView sv;
        Label title;
        Label labelButton;
        Grid gridButton;
        Image bgImage;

        public MainPage()
        {
            Title = "Avaleht";

            BackgroundImageSource = "taust.jpg";

            vsl = new VerticalStackLayout();

            title = new Label
            {
                Text = "PUZZLE",
                FontFamily = "Monoton-Regular",
                FontSize = 45,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Colors.White,
                Margin = new Thickness(0, 40, 0, 10)
            };

            vsl.Add(title);

            for (int i = 0; i < lehed.Count; i++)
            {
                int index = i;

                gridButton = new Grid
                {
                    WidthRequest = 220,
                    HeightRequest = 220,
                    HorizontalOptions = LayoutOptions.Center
                };

                bgImage = new Image
                {
                    Source = "silverpuzzle.jpg",
                    Aspect = Aspect.AspectFill
                };

                labelButton = new Label
                {
                    Text = tekstid[i],
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    TextColor = Colors.Black,
                    FontSize = 20,
                    FontFamily = "Monoton-Regular"
                };

                gridButton.Children.Add(bgImage);
                gridButton.Children.Add(labelButton);

                var tapGesture = new TapGestureRecognizer();
                tapGesture.Tapped += (s, e) =>
                {
                    Navigation.PushAsync(lehed[index]);
                };
                gridButton.GestureRecognizers.Add(tapGesture);

                vsl.Add(gridButton);
            }

            sv = new ScrollView { Content = vsl };

            Content = sv;
        }
    }
}
