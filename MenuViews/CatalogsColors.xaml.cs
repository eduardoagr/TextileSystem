namespace TextileSystem.MenuViews;

public partial class CatalogsColors : ContentPage {

    public CatalogsColors(CatalogsColorsViewModel catalogsColors) {
        InitializeComponent();

        BindingContext = catalogsColors;
    }
}