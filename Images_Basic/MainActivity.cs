using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Images_Basic
{
    [Activity(Label = "Android.Xamarin | #3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        ImageView div;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            div = FindViewById<ImageView>(Resource.Id.imageView1);
            div.SetImageResource(Resource.Drawable.page2);
            Button myBtn = FindViewById<Button>(Resource.Id.button1);
            Button myBtn3 = FindViewById<Button>(Resource.Id.button3);
            myBtn.Click += ChangeImage;
            myBtn3.Click += OpacityChange;


        }

        private void OpacityChange(object sender, EventArgs e)
        {
            div.Alpha = 0.2f;
        }

        private void ChangeImage(object sender, EventArgs e)
        {
            div.SetImageResource(Resource.Drawable.lolo);
        }
    }
}

