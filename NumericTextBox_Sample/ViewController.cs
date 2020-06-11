using CoreGraphics;
using Foundation;
using Syncfusion.SfNumericTextBox.iOS;
using System;
using UIKit;

namespace NumericTextBox_Sample
{
    public partial class ViewController : UIViewController
    {
        SfNumericTextBox numericTextBox;
        public ViewController(IntPtr handle) : base(handle)
        {
            numericTextBox = new SfNumericTextBox()
            {
                Frame = new CGRect(10, 50, 350, 40),
                Value = 1000,
                Watermark = "Principal Amount",
                MaximumNumberDecimalDigits = 2,
                FormatString = "c",
                AllowNull = true,
                CultureInfo = new NSLocale("en_us"),
                PercentDisplayMode = SFNumericTextBoxPercentDisplayMode.Compute,
            };

            this.Add(numericTextBox);
        }

      

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}