﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        public MasterDetailPage1Detail()
        {
            InitializeComponent();
        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            var firebaseAuth = DependencyService.Get<IFirebaseAuth>();

            firebaseAuth.CreateNewUser();
        }
    }
}