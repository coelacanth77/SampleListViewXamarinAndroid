using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SampleListViewXamarinAndroid
{
    [Activity(Label = "SampleListViewXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            var list = FindViewById<ListView>(Resource.Id.listView1);

            var items = new string[] { "List1", "List2", "List3", "List4", "List1", "List2", "List3", "List4", "List1", "List2", "List3", "List4", "List1", "List2", "List3", "List4" };
            list.Adapter = new ArrayAdapter<String>(this, Resource.Layout.ListViewItemTemplate, items);
        }
    }
}

