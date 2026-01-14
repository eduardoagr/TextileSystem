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

    /// <summary>
    /// Reserved for later (action, route, command parameter, etc.)
    /// </summary>
    public string? Key { get; set; }

    public MenuTile WithKey(int section, int group) {
        Key = $"{section}/{group}/{Title}";
        return this;
    }

}
