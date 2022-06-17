using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Maui05Mvvm.Models;
using Maui05Mvvm.Services;

namespace Maui05Mvvm.ViewModels
{
    //---- Method 1: Plain way
    //--------------------------------------------------

    //public class MonkeysViewModel : BaseViewModel
    //{
    //       public ObservableCollection<Monkey> Monkeys { get; } = new();
    //       MonkeyService monkeyService;

    //       public MonkeysViewModel(MonkeyService monkeyService)
    //       {
    //           Title = "Monkey Finder";
    //           this.monkeyService = monkeyService;

    //           this.GetMonkeysCommand = new Command(async () => await GetMonkeysAsync());
    //       }

    //       public Command GetMonkeysCommand { get; } 

    //       private async Task GetMonkeysAsync()
    //       {
    //           if (IsBusy)
    //               return;

    //           try
    //           {
    //               IsBusy = true;
    //               var monkeys = await monkeyService.GetMonkeys();

    //               if (Monkeys.Count != 0)
    //                   Monkeys.Clear();

    //               foreach (var monkey in monkeys)
    //                   Monkeys.Add(monkey);

    //           }
    //           catch (Exception ex)
    //           {
    //               Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
    //               await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
    //           }
    //           finally
    //           {
    //               IsBusy = false;
    //           }

    //       }
    //   }

    //---- Method 2: using CommunityToolkit
    // note : the class should be partial
    //--------------------------------------------------

    public partial class MonkeysViewModel : BaseViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; } = new();
        MonkeyService monkeyService;

        public MonkeysViewModel(MonkeyService monkeyService)
        {
            Title = "Monkey Finder";
            this.monkeyService = monkeyService;
        }

        [ICommand]
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

