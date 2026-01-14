namespace TextileSystem.Views;

public partial class AppShell : Shell {
    public AppShell(AppShellViewModel shellViewModel) {
        InitializeComponent();

        BindingContext = shellViewModel;
    }
}