using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Maui06Carusel.Models;
using Maui06Carusel.Services;

namespace Maui06Carusel.ViewModels
{
    public class MonkeysViewModel : BaseViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; } = new();
        MonkeyService monkeyService;

        public MonkeysViewModel(MonkeyService monkeyService)
        {
            Title = "Monkey Finder";
            this.monkeyService = monkeyService;

            this.GetMonkeysCommand = new Command(async () => await GetMonkeysAsync());

            //directly call data
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

                foreach (var monkey in monkeys)
                    Monkeys.Add(monkey);

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
    }
}

