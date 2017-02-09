using System;
using System.Collections.Generic;
using DevProtocol.Xam.CircleDotDemo.ViewModels;
using Xamarin.Forms;

namespace DevProtocol.Xam.CircleDotDemo.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			BindingContext = new MainViewModel();
			InitializeComponent();
		}
	}
}
