namespace TextileSystem.ViewModels;


public partial class MainPageViewModel : ObservableObject {

    private readonly ILocalizationResourceManager _loc;

    [ObservableProperty]
    public partial bool IsConfigurationsOpen { get; set; }

    [ObservableProperty]
    public partial Color TileColor { get; set; }

    [ObservableProperty]
    public partial LanguageItem SelectedLanguageItem { get; set; }

    public ObservableCollection<MenuSection> Sections { get; }

    [ObservableProperty]
    public partial ObservableCollection<LanguageItem> Languages { get; set; }




    public MainPageViewModel(ILocalizationResourceManager localizationResource) {

        _loc = localizationResource;
        Sections = new ObservableCollection<MenuSection>(MenuFactory.CreateMenu(_loc));
        Languages = LanguageServices.GetSupportedLanguages(_loc);


        SelectedLanguageItem = Languages.FirstOrDefault(l => l.Code == AppSettings.GetLanguage()) ?? Languages.First();
        TileColor = AppSettings.GetTileColor();

    }

    [RelayCommand]
    private void ExecuteTile(MenuTile tile) {
        if(tile is not null) {
            switch(tile.Action) {

                // -----------------------------
                // Captura & Consulta
                // -----------------------------

                case MenuTile.MenuAction.VentaConsultaGeneral:
                    break;

                case MenuTile.MenuAction.VentaConsultaHistorico:
                    break;

                case MenuTile.MenuAction.StockConsultaGeneral:
                    break;

                case MenuTile.MenuAction.StockConsultaAlmacenes:
                    break;

                case MenuTile.MenuAction.TraspasoCaptura:
                    break;

                case MenuTile.MenuAction.TraspasoConsulta:
                    break;

                case MenuTile.MenuAction.VentaCaptura:
                    break;

                case MenuTile.MenuAction.VentaConsulta:
                    break;

                case MenuTile.MenuAction.CompraCaptura:
                    break;

                case MenuTile.MenuAction.CompraConsulta:
                    break;

                // -----------------------------
                // Catálogos
                // -----------------------------

                case MenuTile.MenuAction.ClientesConsulta:
                    WindowFactory.CreateCentered<CatalogsClientsConsult>(_loc["Screen_ClientsConsult"], 1400, 800);
                    break;

                case MenuTile.MenuAction.ProveedoresConsulta:
                    WindowFactory.CreateCentered<CatalogsProvidersConsult>(_loc["Screen_SuppliersConsult"], 1400, 800);
                    break;

                case MenuTile.MenuAction.UsuariosConsulta:
                    WindowFactory.CreateCentered<CatalogsUsersConsult>(_loc["Screen_UsersConsult"], 600, 600);
                    break;

                case MenuTile.MenuAction.ProductosConsulta:
                    WindowFactory.CreateCentered<CatalogsProductConsult>(_loc["Screen_ProductsConsult"], 600, 600);
                    break;

                case MenuTile.MenuAction.ColoresConsulta:
                    WindowFactory.CreateCentered<CatalogsColorsConsult>(_loc["Screen_ColorsConsult"], 600, 600);
                    break;

                // -----------------------------
                // Portales
                // -----------------------------

                case MenuTile.MenuAction.FirmarMovimiento:
                    break;

                case MenuTile.MenuAction.FirmarMovimientoConsulta:
                    break;

                // -----------------------------
                // Análisis
                // -----------------------------

                case MenuTile.MenuAction.InformeNegativos:
                    break;

                case MenuTile.MenuAction.InformeAjustes:
                    break;

                case MenuTile.MenuAction.InformeMovimientos:
                    break;

                default:
                    throw new NotImplementedException(
                        $"Menu action not handled: {tile.Action}"
                    );
            }
        }
    }

    [RelayCommand]
    public void OnColorChanged(Color newColor) {
        TileColor = newColor;
        AppSettings.SetTileColor(newColor);

    }

    [RelayCommand]
    void OpenConfigurations() {
        IsConfigurationsOpen = true;
    }

    partial void OnSelectedLanguageItemChanged(LanguageItem value) {

        if(value is null) return;

        if(_loc.CurrentCulture.Name == value.Code) return;

        // Save language code
        AppSettings.SetLanguage(value.Code);


        // Change culture
        _loc.CurrentCulture = new CultureInfo(value.Code);

        Sections.Clear();
        foreach(var section in MenuFactory.CreateMenu(_loc))
            Sections.Add(section);

        var snapshot = Languages.ToList();

        foreach(var lang in snapshot)
            lang.Display = _loc[$"Settings_{lang.Code}"];
        Languages = new ObservableCollection<LanguageItem>(snapshot);

    }
}