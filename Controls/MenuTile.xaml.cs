namespace TextileSystem.Controls;

public partial class MenuTile : ContentView {
    public MenuTile() {
        InitializeComponent();
    }


    public static readonly BindableProperty TileColorProperty = BindableProperty.Create(
        nameof(TileColor), typeof(Color), typeof(MenuTile));

    public Color TileColor {
        get => (Color)GetValue(TileColorProperty);
        set => SetValue(TileColorProperty, value);
    }


    public static readonly BindableProperty TileProperty =
        BindableProperty.Create(nameof(Tile), typeof(Models.MenuTile), typeof(MenuTile));

    public Models.MenuTile Tile {
        get => (Models.MenuTile)GetValue(TileProperty);
        set => SetValue(TileProperty, value);
    }
}