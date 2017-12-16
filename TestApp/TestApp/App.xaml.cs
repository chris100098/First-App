using System;

using TestApp.Views;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

namespace TestApp
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
            AppCenter.Start("ios={b9984b1c-8755-477b-9815-a252aaac1e06};android={9baaeb24-8e12-462e-bb35-c1eb3b59721e};UWP={2d3ee263-b02c-4346-9a4b-d62cba4b8ff4}", typeof(Analytics), typeof(Crashes), typeof(Push));
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
