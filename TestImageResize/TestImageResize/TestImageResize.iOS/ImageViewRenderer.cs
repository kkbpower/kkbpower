using CoreGraphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestImageResize;
using TestImageResize.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ImageView), typeof(ImageViewRenderer))]
namespace TestImageResize.iOS
{
    class ImageViewRenderer : ViewRenderer<ImageView, UIImageView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ImageView> e)
        {
            base.OnElementChanged(e);

            UIImageView imageView = new UIImageView(new CGRect(new CGPoint(0, 0), new CGSize(100, 100)));
            UIImageView imageView2 = new UIImageView(new CGRect(new CGPoint(0, 150), new CGSize(50, 50)));
            imageView.ContentMode = UIViewContentMode.Center;
            imageView2.ContentMode = UIViewContentMode.Center;

            UIImage rose = UIImage.FromBundle("rose.jpg");
            imageView.Image = rose;
            imageView2.Image = rose.Scale(new CGSize(50, 50));

            base.SetNativeControl(imageView);
            base.SetNativeControl(imageView2);

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing) { }
            base.Dispose(disposing);
        }
    }

}