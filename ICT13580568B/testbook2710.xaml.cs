using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580568B
{
    public partial class testbook2710 : ContentPage
    {
        public testbook2710()
        {
			InitializeComponent();

			salarySlider.ValueChanged += SalarySlider_ValueChanged;
			childrenStepper.ValueChanged += ChildrenStepper_ValueChanged;

			genderPicker.Items.Add("ชาย");
			genderPicker.Items.Add("หญิง");
		}

		void SalarySlider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			salaryLabel.Text = e.NewValue.ToString("N0");
		}

		void ChildrenStepper_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			childrenLabel.Text = e.NewValue.ToString("N0");
		}
	}
}




