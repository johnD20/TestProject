using System;

using UIKit;

namespace TestProject
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            goButton.TouchUpInside+= GoButton_TouchUpInside;
        }

        void GoButton_TouchUpInside(object sender, EventArgs e)
        {
			float height = float.Parse(HeightTextField.Text);
			float weight = float.Parse(WeightTextField.Text);

            float bmi = (weight / (height * height));

            bmiLabel.Text = bmi.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
