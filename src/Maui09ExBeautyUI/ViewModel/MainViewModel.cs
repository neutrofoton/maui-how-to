using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Maui09ExBeautyUI.Model;

namespace Maui09ExBeautyUI.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private ObservableCollection<Places> places;

        public ObservableCollection<Places> Places
        {
            get { return places; }
            set
            {
                places = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("places"));
            }
        }


        public MainViewModel()
        {
            places = new ObservableCollection<Places>();
            AddData();
        }

        private void AddData()
        {
            Places.Add(new Places
            {

                Id = 0,
                Title = "The beautiful lake",
                Country = "Norway",
                ImgSource = "https://images.pexels.com/photos/2217365/pexels-photo-2217365.jpeg"
            });
            Places.Add(new Places
            {

                Id = 0,
                Title = "Adventure of snow",
                Country = "Nepal",
                ImgSource = "https://images.pexels.com/photos/753772/pexels-photo-753772.jpeg"
            });
            Places.Add(new Places
            {

                Id = 0,
                Title = "Beach is where life is",
                Country = "Malaysia",
                ImgSource = "https://images.pexels.com/photos/6023784/pexels-photo-6023784.jpeg"
            });
        }
    }
}

