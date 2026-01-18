namespace TextileSystem.Views;

public partial class MainPage : ContentPage {

    public MainPage(MainPageViewModel mainPageViewModel, IWindowService windowService) {
        InitializeComponent();

        BindingContext = mainPageViewModel;
    }
}