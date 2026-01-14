namespace TextileSystem.Services;

public static class MenuFactory {
    public static IList<MenuSection> CreateMenu() {

        var menu = new List<MenuSection>();

        var firstTab = new MenuSection {
            Title = "Captura & Consulta",
            Groups = [
                new MenuGroup {
                    Title = "Venta consulta",
                    Tiles = [
                        new MenuTile { Title = "General"}.WithKey(1,1),
                        new MenuTile { Title = "Historico"}.WithKey(1,1),
                    ]
                },
                new MenuGroup {
                    Title = "Consulta de stocks",
                    Tiles = [
                        new MenuTile { Title = "General" }.WithKey(1, 2),
                        new MenuTile { Title = "Almacenes" }.WithKey(1, 2),
                        new MenuTile { Title = "Tienda" }.WithKey(1, 2),
                    ]
                },
                new MenuGroup {
                    Title = "Envio de captonar",
                    Tiles = [
                        new MenuTile { Title = "Dibujos" }.WithKey(1, 3),
                        new MenuTile { Title = "Envio" }.WithKey(1, 3),
                        new MenuTile { Title = "Consulta" }.WithKey(1, 3),
                        new MenuTile { Title = "Inventario en proceso" }.WithKey(1, 3),
                    ]
                },
                new MenuGroup {
                    Title = "Recepcion capitonado",
                    Tiles = [
                        new MenuTile { Title = "Recepcion" }.WithKey(1, 4),
                        new MenuTile { Title = "Consulta" }.WithKey(1, 4),
                    ]
                },
                new MenuGroup {
                    Title = "Traspasos generales",
                    Tiles = [
                        new MenuTile { Title = "Captura" }.WithKey(1, 5),
                        new MenuTile { Title = "Chnc - centro" }.WithKey(1, 5),
                        new MenuTile { Title = "Chnc - portales" }.WithKey(1, 5),
                        new MenuTile { Title = "Consulta" }.WithKey(1, 5),
                    ]
                },
                new MenuGroup {
                    Title = "Traspasos almacen a tienda",
                    Tiles = [
                        new MenuTile { Title = "Captura" }.WithKey(1, 6),
                        new MenuTile { Title = "Consulta" }.WithKey(1, 6),
                    ]
                },
                new MenuGroup {
                    Title = "Ventas captura",
                    Tiles = [
                        new MenuTile { Title = "A. portales" }.WithKey(1, 7),
                        new MenuTile { Title = "A. centro" }.WithKey(1, 7),
                        new MenuTile { Title = "Chiconcuac" }.WithKey(1, 7),
                        new MenuTile { Title = "Tienda" }.WithKey(1, 7),
                    ]
                },
                new MenuGroup {
                    Title = "Compras",
                    Tiles = [
                        new MenuTile { Title = "Compras" }.WithKey(1, 8),
                        new MenuTile { Title = "Consulta" }.WithKey(1, 8),
                    ]
                },
                new MenuGroup {
                    Tiles = [
                        new MenuTile { Title = "Vriaciones" }.WithKey(1, 9),
                    ]
                },
            ]
        };
        var secondTab = new MenuSection {
            Title = "Catalogos",
            Groups = [
                new MenuGroup {
                    Title = "Principales",
                    Tiles =[
                        new MenuTile { Title = "Clientes" }.WithKey(2,1),
                        new MenuTile { Title = "Proveedores" }.WithKey(2,2),
                        new MenuTile { Title = "Usuarios" }.WithKey(2,3),
                        new MenuTile { Title = "Productos" }.WithKey(2,4),
                        new MenuTile { Title = "Colores" }.WithKey(2,5),
                    ]
                }
            ]
        };
        var thirdTab = new MenuSection {
            Title = "Movimientos portales",
            Groups = [
              new MenuGroup {
                  Title = "Firmar movimientos",
                  Tiles =[
                      new MenuTile { Title = "Firmar" }.WithKey(3,1),
                      new MenuTile { Title = "Firmar consultar" }.WithKey(3,2),
                  ]
              }
            ]
        };
        var fourthTab = new MenuSection {
            Title = "Analisis de datos",
            Groups = [
                new MenuGroup {
                    Title = "Informes",
                    Tiles = [
                        new MenuTile { Title = "Negaivos" }.WithKey(4,1),
                        new MenuTile { Title = "Ajustes" }.WithKey(4,2),
                        new MenuTile { Title = "Movimientos" }.WithKey(4,3),
                    ]
                }
            ]
        };

        menu.Add(firstTab);
        menu.Add(secondTab);
        menu.Add(thirdTab);
        menu.Add(fourthTab);

        return menu;
    }
}

