namespace TextileSystem;

public partial class App : Application {

    public static IServiceProvider? Services { get; private set; }

    private readonly AppShell appShell;

    public App(IServiceProvider service, AppShell shell) {
        InitializeComponent();

        appShell = shell;
        Services = service;
    }

    protected override Window CreateWindow(IActivationState? activationState) {
        var window = new Window(appShell); // tu Shell DI
        return window;

    }
}