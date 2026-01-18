#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;

using WinRT.Interop;
#endif

#if MACCATALYST
using CoreGraphics;

using UIKit;
#endif

namespace TextileSystem.Services;

public class WindowService : IWindowService {

    public void MaximizeCurrentWindow() {
        var displayInfo = DeviceDisplay.MainDisplayInfo;

        var widthDip = displayInfo.Width / displayInfo.Density;
        var heightDip = displayInfo.Height / displayInfo.Density;

#if WINDOWS
        var windows = Application.Current?.Windows;
        if(windows != null && windows.Count > 0) {
            var mauiWindow = windows[0];
            var platformWindow = mauiWindow.Handler.PlatformView;

            var hwnd = WindowNative.GetWindowHandle(platformWindow);
            var windowId = Win32Interop.GetWindowIdFromWindow(hwnd);
            var appWindow = AppWindow.GetFromWindowId(windowId);

            if(appWindow.Presenter is OverlappedPresenter presenter)
                presenter.Maximize();
        }


#elif MACCATALYST
        var windows = Application.Current?.Windows;
        if(windows == null || windows.Count == 0)
            return;

        var uiWindow = windows[0].Handler.PlatformView as UIWindow;
        if(uiWindow?.WindowScene?.SizeRestrictions == null)
            return;

        var targetSize = new CGSize(widthDip, heightDip);

        // Lock window to the target size
        uiWindow.WindowScene.SizeRestrictions.MinimumSize = targetSize;
        uiWindow.WindowScene.SizeRestrictions.MaximumSize = targetSize;

        // Optional restore
        Task.Run(async () => {
            await Task.Delay(1000);
            MainThread.BeginInvokeOnMainThread(() => {
                uiWindow.WindowScene.SizeRestrictions.MinimumSize = new CGSize(200, 200);
                uiWindow.WindowScene.SizeRestrictions.MaximumSize = new CGSize(5000, 5000);
            });
        });
#endif
    }
}