using Xamarin.Forms;

namespace ICT13580568B
{
    public partial class ICT13580568BPage : ContentPage
    {
        

        public ICT13580568BPage()
        {
            InitializeComponent();
            okButton.Clicked += OkButton_Clicked;
            genderPicker.Items.Add("male");
            genderPicker.Items.Add("female");
            mySlider.ValueChanged += MySlider_ValueChanged;
            mystepper.ValueChanged += Mystepper_ValueChanged;
		}
		void OkButton_Clicked(object sender, System.EventArgs e)
		{
            firstNameLabel.Text = firstNameEntry.Text;
		}

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void Mystepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();

        }
    }
}
