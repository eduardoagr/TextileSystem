namespace TextileSystem;

public partial class App : Application {

   private readonly AppShell appShell;

    public App(AppShell shell) {
        InitializeComponent();

        appShell = shell;
    }

    protected override Window CreateWindow(IActivationState? activationState) {
        return new Window(appShell);
    }
}