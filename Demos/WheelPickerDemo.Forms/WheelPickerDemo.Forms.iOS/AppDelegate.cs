﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Vapolia.WheelPickerForms;
using Vapolia.WheelPickerForms.Ios;
using WheelPickerDemo.Forms;
using Xamarin.Forms;

//Required by Xamarin Forms infrastructure (Xamarin Forms < 2.3.5)
[assembly: ExportRenderer(typeof(WheelPicker), typeof(WheelPickerRenderer))]

namespace Vapolia.WheelPickerDemo.Forms.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            WheelPickerRenderer.InitializeForms();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
