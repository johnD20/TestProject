// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TestProject
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bmiLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton goButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField HeightTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField WeightTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bmiLabel != null) {
                bmiLabel.Dispose ();
                bmiLabel = null;
            }

            if (goButton != null) {
                goButton.Dispose ();
                goButton = null;
            }

            if (HeightTextField != null) {
                HeightTextField.Dispose ();
                HeightTextField = null;
            }

            if (WeightTextField != null) {
                WeightTextField.Dispose ();
                WeightTextField = null;
            }
        }
    }
}