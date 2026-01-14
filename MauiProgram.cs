

namespace TextileSystem {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            SyncfusionLicenseProvider.RegisterLicense(Keys.SyncfusionLicenseKey);
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureSyncfusionCore().ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            #region Register pages and viewmodels for dependency injection

            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddSingleton<AppShellViewModel>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddSingleton<AuthPage>();
            builder.Services.AddSingleton<AuthPageViewModel>();

            #endregion

            return builder.Build();
        }
    }
}