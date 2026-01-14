namespace TextileSystem.ViewModels {
    public partial class MainPageViewModel : ObservableObject {

        public ObservableCollection<MenuSection> Sections { get; set; }

        public MainPageViewModel() {

            Sections = new ObservableCollection<MenuSection>(MenuFactory.CreateMenu());

        }

        [RelayCommand]
        private void ExecuteTile(MenuTile tile) {
            if(tile == null)
                return;

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

                case MenuTile.MenuAction.Clientes:
                    break;

                case MenuTile.MenuAction.Proveedores:
                    break;

                case MenuTile.MenuAction.Usuarios:
                    break;

                case MenuTile.MenuAction.Productos:
                    break;

                case MenuTile.MenuAction.Colores:
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
}
