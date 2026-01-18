
namespace TextileSystem.MenuViews;

public partial class CatalogsProductcs : ContentPage {
    public CatalogsProductcs(CatalogsProductcsViewModel catalogsProductcsView) {
        InitializeComponent();

        BindingContext = catalogsProductcsView;
    }
}