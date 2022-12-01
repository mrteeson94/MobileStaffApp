﻿using ROIStaffApp.Services;
using ROIStaffApp.Views;
using System;
using System.IO;
using Xamarin.Forms;

namespace ROIStaffApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new HomePage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
