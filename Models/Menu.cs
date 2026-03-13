namespace TextileSystem.Models;

public class MenuSection {

    public string Title { get; set; } = string.Empty;

    public ObservableCollection<MenuGroup> Groups { get; set; } = [];
}

public class MenuGroup {

    public string Title { get; set; } = string.Empty;

    public ObservableCollection<MenuTile> Tiles { get; set; } = [];
}

public partial class MenuTile : ObservableObject {

    public string Title { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;

    public string HelpText { get; set; } = string.Empty;

    public MenuAction Action { get; set; }

}
