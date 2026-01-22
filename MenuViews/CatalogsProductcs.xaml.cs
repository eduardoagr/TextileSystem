
namespace TextileSystem.MenuViews;

public partial class CatalogsProductcs : ContentPage
{
    public CatalogsProductcs(CatalogsProductcsViewModel catalogsProductcsView, ICustomDialogService dialogService)
    {
        InitializeComponent();

        catalogsProductcsView.SetDialogService(dialogService);

        BindingContext = catalogsProductcsView;
    }
}