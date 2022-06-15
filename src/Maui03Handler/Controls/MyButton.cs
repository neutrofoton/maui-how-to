using System;
namespace Maui03Handler.Controls
{
	public class MyButton : Button
	{
        #region Example custom behaviour if needed
    
     

        public static readonly BindableProperty AkhiranIOSProperty =
            BindableProperty.Create(nameof(AkhiranIOS), typeof(string), typeof(MainPage), "");

        public string AkhiranIOS
        {
            get { return (string)GetValue(AkhiranIOSProperty); }
            set { SetValue(AkhiranIOSProperty, value); }
        }
        #endregion
    }
}

