using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580568B
{
    public partial class MyPage2 : ContentPage
    {
        public MyPage2()
        {
            InitializeComponent();

            nextButton.Clicked += NextButton_Clicked;
            backButton.Clicked += BackButton_Clicked;
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
