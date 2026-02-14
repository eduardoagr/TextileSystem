namespace TextileSystem;

public partial class App : Application {

    public static IServiceProvider? Services { get; private set; }

    private readonly AppShell _shell;

    public App(IServiceProvider services, AppShell shell) {
        InitializeComponent();
        Services = services;
        _shell = shell;
    }

    protected override Window CreateWindow(IActivationState? activationState) {
        const double windowWidth = 320;
        const double windowHeight = 320;

        var display = DeviceDisplay.Current.MainDisplayInfo;
        var screenWidth = display.Width / display.Density;
        var screenHeight = display.Height / display.Density;

        return new Window(_shell) {
            Width = windowWidth,
            Height = windowHeight,
            MinimumWidth = windowWidth,
            MinimumHeight = windowHeight,
            X = (screenWidth - windowWidth) / 2,
            Y = (screenHeight - windowHeight) / 2
        };
    }
}