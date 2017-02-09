using System;
namespace DevProtocol.Xam.CircleDotDemo.ViewModels
{
	public interface INotifyPropertyChanging
	{
		event EventHandler<PropertyChangingEventArgs> PropertyChanging;
	}
}
