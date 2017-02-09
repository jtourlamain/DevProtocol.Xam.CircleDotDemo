using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace DevProtocol.Xam.CircleDotDemo.ViewModels
{
	public class MainViewModel: BaseViewModel
	{
		private int circles = 4;
		private int circlesActivated = 0;
		public MainViewModel()
		{
		}

		#region Bindable Properties
		private bool isCircle1Active;
		public bool IsCircle1Active
		{
			get { return isCircle1Active; }
			set { SetProperty(ref isCircle1Active, value); }
		}

		private bool isCircle2Active;
		public bool IsCircle2Active
		{
			get { return isCircle2Active; }
			set { SetProperty(ref isCircle2Active, value); }
		}

		private bool isCircle3Active;
		public bool IsCircle3Active
		{
			get { return isCircle3Active; }
			set { SetProperty(ref isCircle3Active, value); }
		}

		private bool isCircle4Active;
		public bool IsCircle4Active
		{
			get { return isCircle4Active; }
			set { SetProperty(ref isCircle4Active, value); }
		}
		#endregion

		#region Commands
		private ICommand activateCirlceCommand;
		public ICommand ActivateCircleCommand
		{
			get { return activateCirlceCommand ?? (activateCirlceCommand = new Command(ExecuteActivateCircleCommand)); }
		}

		private ICommand desActivateCirlceCommand;
		public ICommand DesactivateCircleCommand
		{
			get { return desActivateCirlceCommand ?? (desActivateCirlceCommand = new Command(ExecuteDesactivateCircleCommand)); }
		}
		#endregion

		private void ExecuteActivateCircleCommand()
		{
			if (circlesActivated < circles)
			{
				circlesActivated += 1;
				SetCircleDots();
			}
		}

		private void ExecuteDesactivateCircleCommand()
		{
			if (circlesActivated > 0)
			{
				circlesActivated -= 1;
				SetCircleDots();
			}
		}

		private void SetCircleDots()
		{
			IsCircle1Active = circlesActivated > 0;
			IsCircle2Active = circlesActivated > 1;
			IsCircle3Active = circlesActivated > 2;
			IsCircle4Active = circlesActivated > 3;
		}
	}
}
