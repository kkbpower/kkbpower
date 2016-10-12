using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using XamarinAndroidPhotoViewer;
using Android.Graphics.Drawables;

namespace TestImageZoom.Droid
{
    [Activity(Label = "ImageViewer")]
    public class ImageViewer : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ImageViewer);


            LinearLayout layout = FindViewById<LinearLayout>(Resource.Id.linear);
            /*  ImageViewExt »ç¿ë
                ImageViewExt imageView = new ImageViewExt(this);
                imageView.SetImageResource(Resource.Drawable.waterfront);
                imageView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent); 
                
                layout.AddView(imageView);
             */

            PhotoView photoView = new PhotoView(this);
            photoView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            //Drawable bitmap = Resources.GetDrawable(Resource.Drawable.waterfront);
            photoView.SetImageResource(Resource.Drawable.waterfront);
            //photoView.SetImageDrawable(bitmap);

            layout.AddView(photoView);

            PhotoViewAttacher attacher = new PhotoViewAttacher(photoView);
            //attacher.Update();

            



        }
    }
}