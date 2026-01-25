namespace TextileSystem.ViewModels;


public partial class MainPageViewModel : ObservableObject
{

    private readonly ILocalizationResourceManager _loc;

    [ObservableProperty]
    public partial bool IsConfigurationsOpen
    {
        get; set;
    }

    [ObservableProperty]
    public partial Color TileColor
    {
        get; set;
    }

    [ObservableProperty]
    public partial string SelectedLanguage
    {
        get; set;
    }

    public ObservableCollection<MenuSection> Sections
    {
        get; set;
    }

    public ObservableCollection<string> Languages
    {
        get; set;
    }


    public MainPageViewModel(ILocalizationResourceManager localizationResource)
    {
        _loc = localizationResource;
        Sections = new ObservableCollection<MenuSection>(MenuFactory.CreateMenu(_loc));
        Languages = LanguageServices.GetSupportedLanguages();

        SelectedLanguage = AppSettings.GetLanguage();
        TileColor = AppSettings.GetTileColor();

    }

    [RelayCommand]
    private void ExecuteTile(MenuTile tile)
    {
        if (tile is not null)
        {
            switch (tile.Action)
            {

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
                    WindowFactory.CreateCentered<CatalogsClientsConsult>("Consultar clientes", 1400, 800);
                    break;

                case MenuTile.MenuAction.ProveedoresConsulta:
                    WindowFactory.CreateCentered<CatalogsProvidersConsult>("Consultar proveedores", 1400, 800);
                    break;

                case MenuTile.MenuAction.UsuariosConsulta:
                    WindowFactory.CreateCentered<CatalogsUsersConsult>("Consultar ususrios", 600, 600);
                    break;

                case MenuTile.MenuAction.ProductosConsulta:
                    WindowFactory.CreateCentered<CatalogsProductConsult>("Consultar productos", 600, 600);
                    break;

                case MenuTile.MenuAction.ColoresConsulta:
                    WindowFactory.CreateCentered<CatalogsColorsConsult>("Consultar colores", 600, 600);
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
    public void OnColorChanged(Color newColor)
    {
        TileColor = newColor;
        AppSettings.SetTileColor(newColor);

    }

    [RelayCommand]
    void OpenConfigurations()
    {
        IsConfigurationsOpen = true;
    }

    partial void OnSelectedLanguageChanged(string value)
    {
        AppSettings.SetLanguage(value);

        var culture = value switch
        {
            "English" => new CultureInfo("en"),
            "Spanish" => new CultureInfo("es"),
            _ => new CultureInfo("es")
        };

        _loc.CurrentCulture = culture;

        Sections.Clear();
        foreach (var section in MenuFactory.CreateMenu(_loc))
            Sections.Add(section);
    }
}
