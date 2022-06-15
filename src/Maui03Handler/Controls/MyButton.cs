using System;
namespace Maui03Handler.Controls
{
	public class MyButton : Button
	{
        #region Example custom behaviour if needed
    
     

        public static readonly BindableProperty PrefixIOSProperty =
            BindableProperty.Create(nameof(PrefixIOS), typeof(string), typeof(MainPage), "");

        public string PrefixIOS
        {
            get { return (string)GetValue(PrefixIOSProperty); }
            set { SetValue(PrefixIOSProperty, value); }
        }
        #endregion
    }
}

