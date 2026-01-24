namespace TextileSystem.ViewModels;


public partial class MainPageViewModel : ObservableObject
{

    [ObservableProperty]
    public partial bool IsConfigurationsOpen
    {
        get; set;
    }


    public ObservableCollection<MenuSection> Sections
    {
        get; set;
    }

    [ObservableProperty]
    public partial Color tileColor
    {
        get; set;
    } = Colors.Blue;

    public MainPageViewModel()
    {

        Sections = new ObservableCollection<MenuSection>(MenuFactory.CreateMenu());

    }

    [RelayCommand]
    private void ExecuteTile(MenuTile tile)
    {
        if (tile == null)
        {
            return;
        }

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

            case MenuTile.MenuAction.Clientes:
                WindowFactory.CreateCentered<CatalogsClients>("Clientes", 600, 600);
                break;

            case MenuTile.MenuAction.Proveedores:
                WindowFactory.CreateCentered<CatalogsProvider>("Proveedores", 600, 600);
                break;

            case MenuTile.MenuAction.Usuarios:
                WindowFactory.CreateCentered<CatalogsUsers>("Ususrios", 600, 430);
                break;

            case MenuTile.MenuAction.Productos:
                WindowFactory.CreateCentered<CatalogsProductcs>("Productos", 600, 300);
                break;

            case MenuTile.MenuAction.Colores:
                WindowFactory.CreateCentered<CatalogsColors>("Colores", 600, 200);
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

            // -----------------------------
            // Configuración
            // -----------------------------

            case MenuTile.MenuAction.ColoresDeTiles:
                IsConfigurationsOpen = true;
                break;

            default:
                throw new NotImplementedException(
                    $"Menu action not handled: {tile.Action}"
                );
        }
    }

    [RelayCommand]
    public void OnColorChanged(Color newColor)
    {
        tileColor = newColor;
    }

}
