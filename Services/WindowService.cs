#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
using WinRT.Interop;
#endif

#if MACCATALYST
using CoreGraphics;

using UIKit;
#endif

namespace TextileSystem.Services;

public class WindowService : IWindowService
{
    public void MaximizeCurrentWindow()
    {
#if WINDOWS
        MaximizeWindows();
#elif MACCATALYST
        MaximizeMac();
#endif
    }

    // -----------------------------
    // WINDOWS IMPLEMENTATION
    // -----------------------------
#if WINDOWS
    void MaximizeWindows()
    {
        var windows = Application.Current?.Windows;
        if (windows == null || windows.Count == 0)
        {
            return;
        }

        var mauiWindow = windows[0];
        var platformWindow = mauiWindow.Handler?.PlatformView;
        if (platformWindow == null)
        {
            return;
        }

        var hwnd = WindowNative.GetWindowHandle(platformWindow);
        var windowId = Win32Interop.GetWindowIdFromWindow(hwnd);
        var appWindow = AppWindow.GetFromWindowId(windowId);

        if (appWindow.Presenter is OverlappedPresenter presenter)
        {
            presenter.Maximize();
        }
    }
#endif

    // -----------------------------
    // MACCATALYST IMPLEMENTATION
    // -----------------------------
#if MACCATALYST
    static void MaximizeMac()
    {
        var nsAppClass = ObjCRuntime.Class.GetHandle("NSApplication");
        var nsApp = ObjCRuntime.Runtime.GetNSObject(nsAppClass);
        var sharedApp = nsApp?.PerformSelector(new ObjCRuntime.Selector("sharedApplication"));
        var keyWindow = sharedApp?.PerformSelector(new ObjCRuntime.Selector("keyWindow"));
        keyWindow?.PerformSelector(new ObjCRuntime.Selector("toggleFullScreen:"), keyWindow);
    }
#endif
}