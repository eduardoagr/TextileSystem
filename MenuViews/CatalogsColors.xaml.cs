namespace TextileSystem.MenuViews;

public partial class CatalogsColors : ContentPage {

    public CatalogsColors(CatalogsColorsViewModel catalogsColors, ICustomDialogService dialogService) {
        InitializeComponent();

        catalogsColors.SetDialogService(dialogService);

        BindingContext = catalogsColors;
    }
}