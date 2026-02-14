#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;

using Windows.Graphics;

using WinRT.Interop;
#endif

#if MACCATALYST
using UIKit;
#endif

namespace TextileSystem.Services;

public class WindowService : IWindowService {

    public void MaximizeCurrentWindow() {

        MainThread.BeginInvokeOnMainThread(MaximizeCurrentWindowCore);
    }

    public static void MaximizeCurrentWindowCore() {
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
    static void MaximizeWindows() {

        if(Application.Current?.Windows is not { Count: > 0 } windows)
            return;

        if(windows[0].Handler?.PlatformView is not { } platformWindow)
            return;

        var hwnd = WindowNative.GetWindowHandle(platformWindow);
        var windowId = Win32Interop.GetWindowIdFromWindow(hwnd);

        if(AppWindow.GetFromWindowId(windowId).Presenter is OverlappedPresenter presenter) {
            presenter.Maximize();
            presenter.IsMaximizable = false;
            presenter.IsResizable = false;
            presenter.IsMinimizable = true;
        }
    }
#endif

    // -----------------------------
    // MACCATALYST IMPLEMENTATION
    // -----------------------------
#if MACCATALYST
    static void MaximizeMac() {

        var scene = UIApplication.SharedApplication
                               .ConnectedScenes
                               .OfType<UIWindowScene>()
                               .FirstOrDefault();

        var window = scene?.Windows.FirstOrDefault();

        if(scene == null || window == null)
            return;


        var bounds = scene.Screen.Bounds;

        scene.RequestGeometryUpdate(
            new UIWindowSceneGeometryPreferencesMac(bounds),
            error => { });

        if(scene.SizeRestrictions is { } restrictions) {
            restrictions.MinimumSize = bounds.Size;
            restrictions.MaximumSize = bounds.Size;
        }
    }
#endif
}