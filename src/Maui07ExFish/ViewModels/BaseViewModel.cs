using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Maui07ExFish.ViewModels
{
	public class BaseViewModel : ObservableObject
	{
		private string? title = string.Empty;

		private string? subtitle = string.Empty;

		private string? icon = string.Empty;

		private bool isBusy;

		private bool isNotBusy = true;

		private bool canLoadMore = true;

		private string? header = string.Empty;

		private string? footer = string.Empty;

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string? Title
		{
			get
			{
				return title;
			}
			set
			{
				SetProperty(ref title, value, "Title");
			}
		}

		/// <summary>
		/// Gets or sets the subtitle.
		/// </summary>
		/// <value>The subtitle.</value>
		public string? Subtitle
		{
			get
			{
				return subtitle;
			}
			set
			{
				SetProperty(ref subtitle, value, "Subtitle");
			}
		}

		/// <summary>
		/// Gets or sets the icon.
		/// </summary>
		/// <value>The icon.</value>
		public string? Icon
		{
			get
			{
				return icon;
			}
			set
			{
				SetProperty(ref icon, value, "Icon");
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is busy.
		/// </summary>
		/// <value><c>true</c> if this instance is busy; otherwise, <c>false</c>.</value>
		public bool IsBusy
		{
			get
			{
				return isBusy;
			}
			set
			{
				if (SetProperty(ref isBusy, value, "IsBusy"))
				{
					IsNotBusy = !isBusy;
				}
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is not busy.
		/// </summary>
		/// <value><c>true</c> if this instance is not busy; otherwise, <c>false</c>.</value>
		public bool IsNotBusy
		{
			get
			{
				return isNotBusy;
			}
			set
			{
				if (SetProperty(ref isNotBusy, value, "IsNotBusy"))
				{
					IsBusy = !isNotBusy;
				}
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance can load more.
		/// </summary>
		/// <value><c>true</c> if this instance can load more; otherwise, <c>false</c>.</value>
		public bool CanLoadMore
		{
			get
			{
				return canLoadMore;
			}
			set
			{
				SetProperty(ref canLoadMore, value, "CanLoadMore");
			}
		}

		/// <summary>
		/// Gets or sets the header.
		/// </summary>
		/// <value>The header.</value>
		public string? Header
		{
			get
			{
				return header;
			}
			set
			{
				SetProperty(ref header, value, "Header");
			}
		}

		/// <summary>
		/// Gets or sets the footer.
		/// </summary>
		/// <value>The footer.</value>
		public string? Footer
		{
			get
			{
				return footer;
			}
			set
			{
				SetProperty(ref footer, value, "Footer");
			}
		}
	}
}

