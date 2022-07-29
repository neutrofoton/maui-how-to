namespace Maui07ExFish;

using System.Timers;
using Maui07ExFish.ViewModels;

public partial class OnboardingPage : ContentPage
{
	private Timer timer;

	public OnboardingPage()
	{
		InitializeComponent();
        AnimateCarusel();

    }


    private void AnimateCarusel()
    {
        timer = new Timer(5000)
        {
            AutoReset = true,
            Enabled = true
        };

        OnboardingViewModel onboardingViewModel = this.BindingContext as OnboardingViewModel;
        int caruselItems = onboardingViewModel.Items.Count;

        timer.Elapsed += (sender, e) =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                if (fishingCaruselView.Position == caruselItems - 1)
                {
                    fishingCaruselView.Position = 0;
                    return;
                }

                fishingCaruselView.Position += 1;
            });
        };
    }
}

