using System;
using System.Collections.ObjectModel;
using Maui07ExFish.Models;

namespace Maui07ExFish.ViewModels
{
    public class OnboardingViewModel : BaseViewModel
    {
        private ObservableCollection<OnboardingModel> items;

        public ObservableCollection<OnboardingModel> Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }


        public OnboardingViewModel()
        {
            // create our dummy onboarding items
            Items = new ObservableCollection<OnboardingModel>
            {
                new OnboardingModel
                {
                    Title = "Discover nature and catch the fish",
                    Content = "Crazy houndshark with pipefish snake eel. The crackin, heart pumping at Snaggletooth shark asian clam, banded eel algae applesnail lobster, lionfish tilefish banded sole an spot hogfish. Parrotfish at crazy houndshark with pipefish snake eel.",
                    Image  = "on_board_image1.png"
                    //Image = "https://images.pexels.com/photos/1069712/pexels-photo-1069712.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"
                },
                new OnboardingModel
                {
                    Title = "Find new fishing spots",
                    Content = "Bonnethead at puffer fish pipefish octopus threadfin. Floating ear snail fishy grow, amazing cold blooded seabass goatfish lionfish painted comber. Coral hogfish at Bursa trigger spot hogfish bite yellow pseudochromis weasel shark seabass i.",
                    Image  = "on_board_image2.png"
                },
                new OnboardingModel
                {
                    Title = "Who is fishing near me",
                    Content = "Gold damsel faucet snail, in snake eel sea coral grouper. Mystery snail lionfish papershell houndshark. Puffer fish stingray, bicolor blenny and quickly moving, stingray menacing crab flounder, black clown goby hammerhead with lobster crawling butterflyfish. In the coral threadfin hawkfish. Milk shark swim Asian clam soldierfish. Parrotfish a.",
                    Image  = "on_board_image3.png"
                },
                new OnboardingModel
                {
                    Title = "Find new fishing spots",
                    Content = "Bonnethead at puffer fish pipefish octopus threadfin. Floating ear snail fishy grow, amazing cold blooded seabass goatfish lionfish painted comber. Coral hogfish at Bursa trigger spot hogfish bite yellow pseudochromis weasel shark seabass i.",
                    Image  = "on_board_image4.png"
                },
            };


        }

    }
}

