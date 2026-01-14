namespace TextileSystem.Views;

public partial class AuthPage : ContentPage {
    public AuthPage(AuthPageViewModel authPageViewModel) {
        InitializeComponent();

        BindingContext = authPageViewModel;
    }
}