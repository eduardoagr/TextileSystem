namespace TextileSystem.Services;

public class RibbonMenuBuilder : IRibbonMenuBuilder {
    public IList<MenuSection> CreateMenu(ILocalizationResourceManager loc) {
        var menu = new List<MenuSection>();

        var firstTab = new MenuSection {
            Title = loc["Menu_Capture"],
            Groups =
            [
                new MenuGroup
                {
                    Title = loc["Section_SalesQuery"],
                    Tiles =
                    [
                        new MenuTile { Title = loc["Tile_General"], Action = MenuTile.MenuAction.VentaConsultaGeneral },
                        new MenuTile { Title = loc["Tile_Historic"], Action = MenuTile.MenuAction.VentaConsultaHistorico },
                    ]
                },
                new MenuGroup
                {
                    Title = loc["Section_StockQuery"],
                    Tiles =
                    [
                        new MenuTile { Title =  loc["Tile_StocksGeneral"], Action = MenuTile.MenuAction.StockConsultaGeneral },
                        new MenuTile { Title =  loc["Tile_StocksWarehouses"], Action = MenuTile.MenuAction.StockConsultaAlmacenes },
                    ]
                },
                new MenuGroup
                {
                    Title = loc["Section_Transfers"],
                    Tiles =
                    [
                        new MenuTile { Title = loc["Tile_TransferCapture"], Action = MenuTile.MenuAction.TraspasoCaptura },
                        new MenuTile { Title = loc["Tile_TransferQuery"], Action = MenuTile.MenuAction.TraspasoConsulta },
                    ]
                },
                new MenuGroup
                {
                    Title = loc["Section_Sales"],
                    Tiles =
                    [
                        new MenuTile { Title = loc["Tile_SalesCapture"], Action = MenuTile.MenuAction.VentaCaptura },
                        new MenuTile { Title = loc["Tile_SalesQuery"], Action = MenuTile.MenuAction.VentaConsulta }
                    ]
                },
                new MenuGroup
                {
                    Title = loc["Section_Purchases"],
                    Tiles =
                    [
                        new MenuTile { Title = loc["Tile_PurchaseCapture"], Action = MenuTile.MenuAction.CompraCaptura },
                        new MenuTile { Title = loc["Tile_PurchaseQuery"], Action = MenuTile.MenuAction.CompraConsulta }
                    ]
                },
            ]
        };

        var secondTab = new MenuSection {
            Title = loc["Menu_Catalogs"],
            Groups =
            [
                new MenuGroup
                {
                    Title = loc["Menu_Catalogs_Main"],
                    Tiles =
                    [
                        new MenuTile { Title = loc["Menu_Catalogs_Main_Clients"],   Action = MenuTile.MenuAction.ClientesConsulta },
                        new MenuTile { Title = loc["Menu_Catalogs_Main_Suppliers"], Action = MenuTile.MenuAction.ProveedoresConsulta },
                        new MenuTile { Title = loc["Menu_Catalogs_Main_Users"],     Action = MenuTile.MenuAction.UsuariosConsulta },
                        new MenuTile { Title = loc["Menu_Catalogs_Main_Products"],  Action = MenuTile.MenuAction.ProductosConsulta },
                        new MenuTile { Title = loc["Menu_Catalogs_Main_Colors"],    Action = MenuTile.MenuAction.ColoresConsulta },

                    ]
                }
            ]
        };

        var thirdTab = new MenuSection {
            Title = loc["Menu_PortalMovements"],
            Groups =
            [
                new MenuGroup
                {
                    Title = loc["Menu_PortalMovements_Main"],
                    Tiles =
                    [
                        new MenuTile { Title = loc["Menu_PortalMovements_Main_Sign"],      Action = MenuTile.MenuAction.FirmarMovimiento },
                        new MenuTile { Title = loc["Menu_PortalMovements_Main_SignQuery"], Action = MenuTile.MenuAction.FirmarMovimientoConsulta },
                    ]
                }
            ]
        };

        var fourthTab = new MenuSection {
            Title = loc["Menu_DataAnalysis"],
            Groups =
            [
                new MenuGroup
                {
                    Title = loc["Menu_DataAnalysis_Main"],
                    Tiles =
                    [
                         new MenuTile { Title = loc["Menu_DataAnalysis_Main_Negatives"],  Action = MenuTile.MenuAction.InformeNegativos },
                         new MenuTile { Title = loc["Menu_DataAnalysis_Main_Adjustments"], Action = MenuTile.MenuAction.InformeAjustes },
                         new MenuTile { Title = loc["Menu_DataAnalysis_Main_Movements"],  Action = MenuTile.MenuAction.InformeMovimientos }
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