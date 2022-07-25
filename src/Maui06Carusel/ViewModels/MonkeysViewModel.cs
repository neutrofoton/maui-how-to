using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Maui06Carusel.Models;
using Maui06Carusel.Services;
using Maui06Carusel.Extensions;

namespace Maui06Carusel.ViewModels
{
    public class MonkeysViewModel : BaseViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; } = new();
        public ObservableCollection<string> ImagesList { get; } = new();

        MonkeyService monkeyService;

        public MonkeysViewModel(MonkeyService monkeyService)
        {
            Title = "Monkey Finder";
            this.monkeyService = monkeyService;

            this.GetMonkeysCommand = new Command(async () => await GetMonkeysAsync());

            //directly call data
            _ = GetImagesAsync();
            _ = GetMonkeysAsync();
            
        }

        public Command GetMonkeysCommand { get; }

        private async Task GetMonkeysAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var monkeys = await monkeyService.GetMonkeys();

                if (Monkeys.Count != 0)
                    Monkeys.Clear();

                //foreach (var monkey in monkeys)
                //{
                //    Monkeys.Add(monkey);
                //}

                var ImageLocalList = new string[]
            {
                    "https://images.pexels.com/photos/162520/farmer-man-shepherd-dog-162520.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
                    "https://images.pexels.com/photos/1069712/pexels-photo-1069712.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
                    "https://images.pexels.com/photos/3551498/pexels-photo-3551498.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
                    "https://images.pexels.com/photos/3651618/pexels-photo-3651618.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"
            };

                for (int i = 0; i < monkeys.Count; i++)
                {
                    int idxImage = i % ImageLocalList.Length;
                    var monkey = monkeys[i];
                    monkey.Image = ImageLocalList[idxImage];

                    Monkeys.Add(monkey);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }

        }

        private async Task GetImagesAsync()
        {
            ImagesList.AddRange(new string[] 
            {
                "https://images.pexels.com/photos/162520/farmer-man-shepherd-dog-162520.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
                "https://images.pexels.com/photos/1069712/pexels-photo-1069712.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
                "https://images.pexels.com/photos/3551498/pexels-photo-3551498.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
                "https://images.pexels.com/photos/3651618/pexels-photo-3651618.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"
            });
        }

    }
}

