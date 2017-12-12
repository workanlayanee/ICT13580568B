using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580568B
{
    public partial class NavPage3 : ContentPage
    {
		public NavPage3()
		{
			InitializeComponent();
            backButton.Clicked += BackButton_Clicked;
			backToRootButton.Clicked += BackToRootButton_Clicked;
		}


		void BackToRootButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopToRootAsync();
		}

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}