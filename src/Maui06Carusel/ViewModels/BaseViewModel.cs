using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui06Carusel.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));



        private string title;
        public string Title
        {
            get => title;
            set
            {
                if (title == value)
                    return;

                title = value;
                OnPropertyChanged(); //equal with : OnPropertyChanged("Title"); 
            }
        }

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy == value)
                    return;

                isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy)); //also notifiy change for IsNotBusy property
            }
        }

        public bool IsNotBusy => !IsBusy;
    }
}

