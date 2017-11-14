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
using Phoneword.Droid;
using Xamarin.Forms;
using Firebase.Auth;
using Firebase;
using Android.Net;

[assembly: Dependency(typeof(PhoneFirebaseAuth))]
namespace Phoneword.Droid
{
    class PhoneFirebaseAuth : IFirebaseAuth
    {
        private FirebaseAuth auth;
        public bool InitFirebaseAuth()
        {
            var options = new FirebaseOptions.Builder()
                .SetApplicationId("1:40089167415:android: 6a9dfbe57df904c9")
                .SetApiKey("AIzaSyDBMh02iRLvH7pJWd9XIu42EwQLSwZlhHA")
                .Build();
            
            return true;
        }

        public void CreateNewUser()
        {
            //var context = Forms.Context;
            //var app = FirebaseApp.InitializeApp(context);
            //auth = FirebaseAuth.GetInstance(app);
            //auth.CreateUserWithEmailAndPassword("KevinTest", "test123");
        }

    }
}