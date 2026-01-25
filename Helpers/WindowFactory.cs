namespace TextileSystem.Helpers;

public static class WindowFactory
{

    private static Window? _window;

    public static void CreateCentered<TPage>(string title, double width, double height)
        where TPage : Page
    {

        if (_window != null)
        {
            Application.Current?.ActivateWindow(_window);
            return;
        }

        // Resolve the page from DI, automatically injecting its ViewModel
        var page = App.Services!.GetRequiredService<TPage>();

        var displayInfo = DeviceDisplay.MainDisplayInfo;
        var screenWidth = displayInfo.Width / displayInfo.Density;
        var screenHeight = displayInfo.Height / displayInfo.Density;

        _window = new Window(page)
        {
            Title = title,
            Width = width,
            Height = height,
            X = (screenWidth - width) / 2,
            Y = (screenHeight - height) / 2
        };

        _window.Destroying += (_, _) => _window = null;

        // Window is new → open it
        Application.Current?.OpenWindow(_window);
    }
}
