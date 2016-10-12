using CoreGraphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace TestIOSImageZoom.iOS
{
    class ZoomImageView : UIScrollView
    {
        UIImageView imageView;

        public ZoomImageView()
        {
            CGRect main = UIScreen.MainScreen.Bounds;
            this.Bounds = new CGRect(new CGPoint(0, 0), new CGSize(main.Width, main.Height));
            this.BackgroundColor = UIColor.Blue;
        }

        public void SetImage(UIImage image)
        {
            
            this.imageView = new UIImageView();
            this.imageView.Image = image;
            this.imageView.ContentMode = UIViewContentMode.ScaleAspectFit;
            //this.imageView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

            this.imageView.Frame = new CGRect(new CGPoint(0, 200), new CGSize(image.Size.Width, image.Size.Height));

            
            
            this.MaximumZoomScale = 3f;
            this.MinimumZoomScale = 0.5f;

            this.ContentSize = image.Size;
            this.ZoomScale = this.MinimumZoomScale;
            this.AddSubview(this.imageView);
            this.imageView.BackgroundColor = UIColor.Black;
            System.Diagnostics.Debug.WriteLine("image widt+h : " + image.Size.Width + " height : " + image.Size.Height);
            System.Diagnostics.Debug.WriteLine("imageview widt+h : " + imageView.Frame.Size.Width + " height : " + imageView.Frame.Size.Height);

            foreach (UIView subView in this.Subviews) {
                System.Diagnostics.Debug.WriteLine(subView);
            }
            this.ViewForZoomingInScrollView += (UIScrollView sv) => {
                return this.imageView;
            };
            //this.Delegate = this;
            
            
        }

        public UIView viewForZoomingInScrollView(UIScrollView scrollView)
        {
            System.Diagnostics.Debug.WriteLine("viewForZoomingInScrollView");
            return this.imageView;
        }
    }
}