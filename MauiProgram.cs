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

            #region Menu items

            builder.Services.AddTransient<CatalogsProductcsViewModel>();
            builder.Services.AddTransient<CatalogsProductcs>();

            builder.Services.AddTransient<CatalogsColors>();
            builder.Services.AddTransient<CatalogsColorsViewModel>();

            builder.Services.AddTransient<CatalogsClients>();
            builder.Services.AddTransient<CatalogsClientsViewModel>();

            builder.Services.AddTransient<CatalogsProvider>();
            builder.Services.AddTransient<CatalogsProviderViewModel>();

            builder.Services.AddTransient<CatalogsUsers>();
            builder.Services.AddTransient<CatalogsUsersViewModel>();

            #endregion

            // Messenger (MVVM Toolkit)

            builder.Services.AddSingleton<IMessenger>(WeakReferenceMessenger.Default);

            builder.Services.AddSingleton<IShellService, ShellService>();

            // Window service

            builder.Services.AddSingleton<IWindowService, WindowService>();

            // Dialog service

            builder.Services.AddSingleton<ICustomDialogService, CustomDialogService>();

            #endregion

            return builder.Build();
        }
    }
}