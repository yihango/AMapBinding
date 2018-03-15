using System;

using UIKit;
using AMapFoundationKit;
using MAMapKit;

namespace DemoApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            AMapServices.SharedServices.ApiKey = "ebf541962d1d1060d7c1a66576f12093";
            AMapServices.SharedServices.EnableHTTPS = true;
            MAMapView map = new MAMapView();
            map.Frame = this.View.Bounds;
            map.SetShowsUserLocation(true);
            map.SetUserTrackingMode(MAUserTrackingMode.Follow);
            this.View.AddSubview(map);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}