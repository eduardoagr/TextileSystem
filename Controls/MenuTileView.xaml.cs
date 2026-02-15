
namespace TextileSystem.Controls;

public partial class MenuTileView : ContentView {

    public MenuTileView() {
        InitializeComponent();

    }

    public static readonly BindableProperty TileColorProperty = BindableProperty.Create(
        nameof(TileColor), typeof(Color), typeof(MenuTileView));

    public Color TileColor {
        get => (Color)GetValue(TileColorProperty);
        set => SetValue(TileColorProperty, value);
    }


    public static readonly BindableProperty TileProperty =
        BindableProperty.Create(nameof(Tile), typeof(MenuTile), typeof(MenuTileView));


    public MenuTile Tile {
        get => (MenuTile)GetValue(TileProperty);
        set => SetValue(TileProperty, value);
    }

    void PointerEntered(object sender, PointerEventArgs e) {

        VisualStateManager.GoToState(FrontBorder, "PointerOver");
    }

    void PointerExited(object sender, PointerEventArgs e) {

        VisualStateManager.GoToState(FrontBorder, "Normal");
    }



}
