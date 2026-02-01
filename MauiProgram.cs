namespace TextileSystem;

public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        SyncfusionLicenseProvider.RegisterLicense(Keys.SyncfusionLicenseKey);
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureSyncfusionCore().ConfigureFonts(fonts => {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            fonts.AddFont("MaterialIcons-Regular.ttf", "Mi");

        }).UseMauiCommunityToolkit().UseLocalizationResourceManager(settings => {
            settings.AddResource(AppResources.ResourceManager);
            settings.RestoreLatestCulture(true);
        });
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

        builder.Services.AddTransient<CatalogsProductConsult>();
        builder.Services.AddTransient<CatalogsProductConsultViewModel>();

        builder.Services.AddTransient<CatalogsColorsConsult>();
        builder.Services.AddTransient<CatalogsColorsConsultViewModel>();

        builder.Services.AddTransient<CatalogsUsersConsult>();
        builder.Services.AddTransient<CatalogsUsersConsultViewModel>();

        builder.Services.AddTransient<CatalogsProvidersConsult>();
        builder.Services.AddTransient<CatalogsProvidersConsultViewModel>();

        builder.Services.AddTransient<CatalogsClientsConsult>();
        builder.Services.AddTransient<CatalogsClientsConsultViewModel>();

        #endregion

        // Messenger (MVVM Toolkit)

        builder.Services.AddSingleton<IMessenger>(WeakReferenceMessenger.Default);

        builder.Services.AddSingleton<IShellService, ShellService>();

        // Window service

        builder.Services.AddSingleton<IWindowService, WindowService>();

        // Dialog service

        builder.Services.AddTransient<ICustomDialogService, CustomDialogService>();

        // Menu service

        builder.Services.AddSingleton<IRibbonMenuBuilder, RibbonMenuBuilder>();

        // UI services

        builder.Services.AddSingleton<IUISettingItemsServices, UISettingItemsServices>();

        #endregion

        return builder.Build();
    }
}