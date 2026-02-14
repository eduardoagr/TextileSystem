namespace TextileSystem.ViewModels;

public partial class MainPageViewModel : ObservableObject {

    private readonly IRibbonMenuBuilder _menuBuilder;

    private readonly IUISettingItemsServices _uiSettingsService;


    private readonly ILocalizationResourceManager _loc;

    [ObservableProperty]
    public partial bool IsConfigurationsOpen { get; set; }

    [ObservableProperty]
    public partial Color TileColor { get; set; }

    [ObservableProperty]
    public partial UISettingItems SelectedLanguageItem { get; set; }

    public ObservableCollection<MenuSection> Sections { get; }

    [ObservableProperty]
    public partial ObservableCollection<UISettingItems> Languages { get; set; }

    public MainPageViewModel(ILocalizationResourceManager localizationResource, IRibbonMenuBuilder menuBuilder, IUISettingItemsServices uiSettingsService) {

        _uiSettingsService = uiSettingsService;
        _menuBuilder = menuBuilder;

        _loc = localizationResource;
        Sections = new ObservableCollection<MenuSection>(_menuBuilder.CreateMenu(_loc));
        Languages = _uiSettingsService.GetUISettingItems(_loc);


        SelectedLanguageItem = Languages.FirstOrDefault(l => l.Code == AppSettings.GetLanguage()) ?? Languages.First();
        TileColor = AppSettings.GetTileColor();

    }

    [RelayCommand]
    private void ExecuteTile(MenuTile tile) {
        if(tile is null) {
            return;
        }

        switch(tile.Action) {

            // -----------------------------
            // Captura & Consulta
            // -----------------------------

            case MenuAction.VentaConsultaGeneral:
                break;

            case MenuAction.VentaConsultaHistorico:
                break;

            case MenuAction.StockConsultaGeneral:
                break;

            case MenuAction.StockConsultaAlmacenes:
                break;

            case MenuAction.TraspasoCaptura:
                break;

            case MenuAction.TraspasoConsulta:
                break;

            case MenuAction.VentaCaptura:
                break;

            case MenuAction.VentaConsulta:
                break;

            case MenuAction.CompraCaptura:
                break;

            case MenuAction.CompraConsulta:
                break;

            // -----------------------------
            // Catálogos
            // -----------------------------

            case MenuAction.ClientesConsulta:
                WindowFactory.CreateCentered<CatalogsClientsConsult>(_loc["Screen_ClientsConsult"], 1400, 800);
                break;

            case MenuAction.ProveedoresConsulta:
                WindowFactory.CreateCentered<CatalogsProvidersConsult>(_loc["Screen_SuppliersConsult"], 1400, 800);
                break;

            case MenuAction.UsuariosConsulta:
                WindowFactory.CreateCentered<CatalogsUsersConsult>(_loc["Screen_UsersConsult"], 1000, 600);
                break;

            case MenuAction.ProductosConsulta:
                WindowFactory.CreateCentered<CatalogsProductConsult>(_loc["Screen_ProductsConsult"], 600, 600);
                break;

            case MenuAction.ColoresConsulta:
                WindowFactory.CreateCentered<CatalogsColorsConsult>(_loc["Screen_ColorsConsult"], 600, 600);
                break;

            // -----------------------------
            // Portales
            // -----------------------------

            case MenuAction.FirmarMovimiento:
                break;

            case MenuAction.FirmarMovimientoConsulta:
                break;

            // -----------------------------
            // Análisis
            // -----------------------------

            case MenuAction.InformeNegativos:
                break;

            case MenuAction.InformeAjustes:
                break;

            case MenuAction.InformeMovimientos:
                break;

            default:
                throw new NotImplementedException(
                    $"Menu action not handled: {tile.Action}"
                );
        }
    }


    [RelayCommand]
    public void OnColorChanged(Color newColor) {
        AppSettings.SetTileColor(newColor);
        TileColor = newColor;
    }

    [RelayCommand]
    void OpenConfigurations() {
        IsConfigurationsOpen = true;
    }

    partial void OnSelectedLanguageItemChanged(UISettingItems value) {

        if(value is null) return;

        if(_loc.CurrentCulture.Name == value.Code) return;

        // Save language code
        AppSettings.SetLanguage(value.Code);


        // Change culture
        _loc.CurrentCulture = new CultureInfo(value.Code);

        Sections.Clear();
        foreach(var section in _menuBuilder.CreateMenu(_loc))
            Sections.Add(section);

        var snapshot = Languages.ToList();
        foreach(var lang in snapshot)
            lang.Display = _loc[$"Settings_{lang.Code}"];
        Languages = new ObservableCollection<UISettingItems>(snapshot);

    }
}