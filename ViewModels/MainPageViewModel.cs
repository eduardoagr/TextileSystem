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

            switch(tile.Key) {
                // -----------------------------
                // Section 1 — Captura & Consulta
                // -----------------------------

                case "1/1/General":
                    // TODO: Handle General (Venta consulta)
                    break;

                case "1/1/Historico":
                    // TODO: Handle Historico (Venta consulta)
                    break;

                case "1/2/General":
                    // TODO: Handle General (Consulta de stocks)
                    break;

                case "1/2/Almacenes":
                    // TODO: Handle Almacenes (Consulta de stocks)
                    break;

                case "1/2/Tienda":
                    // TODO: Handle Tienda (Consulta de stocks)
                    break;

                case "1/3/Dibujos":
                    // TODO: Handle Dibujos (Envio de captonar)
                    break;

                case "1/3/Envio":
                    // TODO: Handle Envio (Envio de captonar)
                    break;

                case "1/3/Consulta":
                    // TODO: Handle Consulta (Envio de captonar)
                    break;

                case "1/3/Inventario en proceso":
                    // TODO: Handle Inventario en proceso (Envio de captonar)
                    break;

                case "1/4/Recepcion":
                    // TODO: Handle Recepcion (Recepcion capitonado)
                    break;

                case "1/4/Consulta":
                    // TODO: Handle Consulta (Recepcion capitonado)
                    break;

                case "1/5/Captura":
                    // TODO: Handle Captura (Traspasos generales)
                    break;

                case "1/5/Chnc - centro":
                    // TODO: Handle Chnc - centro (Traspasos generales)
                    break;

                case "1/5/Chnc - portales":
                    // TODO: Handle Chnc - portales (Traspasos generales)
                    break;

                case "1/5/Consulta":
                    // TODO: Handle Consulta (Traspasos generales)
                    break;

                case "1/6/Captura":
                    // TODO: Handle Captura (Traspasos almacen a tienda)
                    break;

                case "1/6/Consulta":
                    // TODO: Handle Consulta (Traspasos almacen a tienda)
                    break;

                case "1/7/A. portales":
                    // TODO: Handle A. portales (Ventas captura)
                    break;

                case "1/7/A. centro":
                    // TODO: Handle A. centro (Ventas captura)
                    break;

                case "1/7/Chiconcuac":
                    // TODO: Handle Chiconcuac (Ventas captura)
                    break;

                case "1/7/Tienda":
                    // TODO: Handle Tienda (Ventas captura)
                    break;

                case "1/8/Compras":
                    // TODO: Handle Compras (Compras)
                    break;

                case "1/8/Consulta":
                    // TODO: Handle Consulta (Compras)
                    break;

                case "1/9/Vriaciones":
                    // TODO: Handle Vriaciones
                    break;


                // -----------------------------
                // Section 2 — Catálogos
                // -----------------------------

                case "2/1/Clientes":
                    // TODO: Handle Clientes
                    break;

                case "2/2/Proveedores":
                    // TODO: Handle Proveedores
                    break;

                case "2/3/Usuarios":
                    // TODO: Handle Usuarios
                    break;

                case "2/4/Productos":
                    // TODO: Handle Productos
                    break;

                case "2/5/Colores":
                    // TODO: Handle Colores
                    break;


                // -----------------------------
                // Section 3 — Movimientos portales
                // -----------------------------

                case "3/1/Firmar":
                    // TODO: Handle Firmar
                    break;

                case "3/2/Firmar consultar":
                    // TODO: Handle Firmar consultar
                    break;


                // -----------------------------
                // Section 4 — Análisis de datos
                // -----------------------------

                case "4/1/Negaivos":
                    // TODO: Handle Negaivos
                    break;

                case "4/2/Ajustes":
                    // TODO: Handle Ajustes
                    break;

                case "4/3/Movimientos":
                    // TODO: Handle Movimientos
                    break;


                // -----------------------------
                // Default
                // -----------------------------
                default:
                    // Unknown tile
                    break;
            }
        }
    }
}
