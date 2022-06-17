using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui05Mvvm.ViewModels
{
    //---- Method 1: Plain way
    //--------------------------------------------------

    //public class BaseViewModel : INotifyPropertyChanged
    //{
    //    #region INotifyPropertyChanged

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    #endregion

    //    public void OnPropertyChanged([CallerMemberName] string name = null) =>
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));



    //    private string title;
    //    public string Title
    //    {
    //        get => title;
    //        set
    //        {
    //            if (title == value)
    //                return;

    //            title = value;
    //            OnPropertyChanged(); //equal with : OnPropertyChanged("Title"); 
    //        }
    //    }

    //    private bool isBusy;
    //    public bool IsBusy
    //    {
    //        get => isBusy;
    //        set
    //        {
    //            if (isBusy == value)
    //                return;

    //            isBusy = value;
    //            OnPropertyChanged();
    //            OnPropertyChanged(nameof(IsNotBusy)); //also notifiy change for IsNotBusy property
    //        }
    //    }

    //    public bool IsNotBusy => !IsBusy;
    //}

    //---- Method 2: using CommunityToolkit
    // note : the class should be partial
    //--------------------------------------------------

    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;
    }
}

