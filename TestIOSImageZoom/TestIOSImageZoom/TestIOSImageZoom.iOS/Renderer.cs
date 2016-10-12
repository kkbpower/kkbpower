using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using TestIOSImageZoom;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using TestIOSImageZoom.iOS;
using CoreGraphics;

[assembly: ExportRenderer(typeof(TestIOSImageZoom.ZoomImageView), typeof(Renderer))]
namespace TestIOSImageZoom.iOS
{
    public class Renderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            //UIImageView imageView = new UIImageView();
            ZoomImageView imageView = new ZoomImageView();
            UIImage image = UIImage.FromBundle("rose.jpg");
            imageView.Frame = new CGRect(new CGPoint(0, 0), new CGSize(300, 300));
            imageView.SetImage(image);

            base.SetNativeControl(imageView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) { }
            base.Dispose(disposing);
        }
    }
}