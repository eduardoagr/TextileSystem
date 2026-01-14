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
                        new MenuTile { Title = "General", Action = MenuTile.MenuAction.VentaConsultaGeneral },
                        new MenuTile { Title = "Historico", Action = MenuTile.MenuAction.VentaConsultaHistorico },
                    ]
                },
                new MenuGroup {
                    Title = "Consulta de stocks",
                    Tiles = [
                        new MenuTile { Title = "General", Action = MenuTile.MenuAction.StockConsultaGeneral},
                        new MenuTile { Title = "Almacenes", Action = MenuTile.MenuAction.StockConsultaAlmacenes },
                    ]
                },
                new MenuGroup {
                    Title = "Traspasos generales",
                    Tiles = [
                        new MenuTile { Title = "Captura", Action = MenuTile.MenuAction.TraspasoCaptura },
                        new MenuTile { Title = "Consulta", Action = MenuTile.MenuAction.TraspasoConsulta },
                    ]
                },
                new MenuGroup {
                    Title = "Ventas",
                    Tiles = [
                        new MenuTile { Title = "Captura", Action = MenuTile.MenuAction.VentaCaptura },
                        new MenuTile { Title = "Consulta", Action = MenuTile.MenuAction.VentaConsulta }
                    ]
                },
                new MenuGroup {
                    Title = "Compras",
                    Tiles = [
                        new MenuTile { Title = "Compras", Action = MenuTile.MenuAction.CompraCaptura },
                        new MenuTile { Title = "Consulta", Action = MenuTile.MenuAction.CompraConsulta }
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
                        new MenuTile { Title = "Clientes", Action = MenuTile.MenuAction.Clientes },
                        new MenuTile { Title = "Proveedores", Action = MenuTile.MenuAction.Proveedores },
                        new MenuTile { Title = "Usuarios", Action = MenuTile.MenuAction.Usuarios },
                        new MenuTile { Title = "Productos", Action = MenuTile.MenuAction.Productos },
                        new MenuTile { Title = "Colores", Action = MenuTile.MenuAction.Colores },
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
                      new MenuTile { Title = "Firmar", Action = MenuTile.MenuAction.FirmarMovimiento },
                      new MenuTile { Title = "Firmar consultar", Action = MenuTile.MenuAction.FirmarMovimientoConsulta },
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
                        new MenuTile { Title = "Negaivos", Action = MenuTile.MenuAction.InformeNegativos },
                        new MenuTile { Title = "Ajustes", Action = MenuTile.MenuAction.InformeAjustes },
                        new MenuTile { Title = "Movimientos", Action = MenuTile.MenuAction.InformeMovimientos },
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

