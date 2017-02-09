using System;
using Xamarin.Forms;

namespace DevProtocol.Xam.CircleDotDemo.Controls
{
	public class CircleDot: View
	{
		public static readonly BindableProperty FillColorProperty =
		   BindableProperty.Create(nameof(FillColor), typeof(Color), typeof(CircleDot), Color.Black);

		public Color FillColor
		{
			get { return (Color)GetValue(FillColorProperty); }
			set { SetValue(FillColorProperty, value); }
		}

		public static readonly BindableProperty StrokeColorProperty =
		   BindableProperty.Create(nameof(StrokeColor), typeof(Color), typeof(CircleDot), Color.Black);

		public Color StrokeColor
		{
			get { return (Color)GetValue(StrokeColorProperty); }
			set { SetValue(StrokeColorProperty, value); }
		}

		public static readonly BindableProperty ActiveProperty =
		  BindableProperty.Create(nameof(Active), typeof(bool), typeof(CircleDot), false);

		public bool Active
		{
			get { return (bool)GetValue(ActiveProperty); }
			set { SetValue(ActiveProperty, value); }
		}
	}
}
