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

using Android.Telephony;
using Phoneword.Droid;
using Xamarin.Forms;
using Uri = Android.Net.Uri;
using Android.Net;

[assembly: Dependency(typeof(PhoneNetwork))]
namespace Phoneword.Droid
{
    class PhoneNetwork : INetwork
    {

        public string getNetwork()
        {
            Context context = Xamarin.Forms.Forms.Context;
            ConnectivityManager cm = (ConnectivityManager)context.GetSystemService(Context.ConnectivityService);
            NetworkInfo connection = cm.ActiveNetworkInfo;
            connection.ToString();

            return connection.ToString();
        }
    }
}
