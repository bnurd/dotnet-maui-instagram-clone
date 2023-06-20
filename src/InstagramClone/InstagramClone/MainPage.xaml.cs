using InstagramClone.ViewModels;

namespace InstagramClone;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new MainPageViewModel();
    }

}


