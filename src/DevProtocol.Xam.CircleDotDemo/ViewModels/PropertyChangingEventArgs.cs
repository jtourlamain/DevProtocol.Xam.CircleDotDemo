using System;
namespace DevProtocol.Xam.CircleDotDemo.ViewModels
{
	public class PropertyChangingEventArgs : EventArgs
	{
		private readonly string _name;

		public PropertyChangingEventArgs(string propertyName)
		{
			_name = propertyName;
		}

		public virtual string PropertyName
		{
			get
			{
				return _name;
			}
		}
	}
}
