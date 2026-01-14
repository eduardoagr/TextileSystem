namespace TextileSystem.Models;

/// <summary>
/// Represents a top-level tab
/// (e.g. Captura, Catálogos, Movimientos)
/// </summary>
public class MenuSection {

    public string Title { get; set; } = string.Empty;

    public ObservableCollection<MenuGroup> Groups { get; set; } = [];
}

/// <summary>
/// Represents a group of tiles inside a tab
/// (e.g. Ventas consulta, Catálogos principales)
/// </summary>
public class MenuGroup {

    public string Title { get; set; } = string.Empty;

    public ObservableCollection<MenuTile> Tiles { get; set; } = [];
}

/// <summary>
/// Represents a single tile (icon + text)
/// </summary>

public class MenuTile {

    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Icon resource name (png / svg)
    /// </summary>
    public string Icon { get; set; } = string.Empty;

    public MenuAction Action { get; set; }

    public enum MenuAction {

        // Captura & Consulta
        VentaConsultaGeneral,
        VentaConsultaHistorico,
        StockConsultaGeneral,
        StockConsultaAlmacenes,
        TraspasoCaptura,
        TraspasoConsulta,
        VentaCaptura,
        VentaConsulta,
        CompraCaptura,
        CompraConsulta,

        // Catálogos
        Clientes,
        Proveedores,
        Usuarios,
        Productos,
        Colores,

        // Portales
        FirmarMovimiento,
        FirmarMovimientoConsulta,

        // Análisis
        InformeNegativos,
        InformeAjustes,
        InformeMovimientos
    }
}
