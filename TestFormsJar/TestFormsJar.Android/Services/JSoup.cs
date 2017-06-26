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
using TestFormsJar.Services;
using MyJSoup = Org.Jsoup;

[assembly: Xamarin.Forms.Dependency(typeof(TestFormsJar.Droid.Services.JSoup))]
namespace TestFormsJar.Droid.Services
{
    public class JSoup : IJSoup
    {
        public string Test(string url)
        {
            return MyJSoup.Helper.HttpConnection.Connect(url).Get().ToString();
        }
    }
}