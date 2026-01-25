namespace TextileSystem.MenuViews;

public partial class CatalogsProductConsult : ContentPage
{
    public CatalogsProductConsult(CatalogsProductConsultViewModel catalogsProductConsultViewModel)
    {
        InitializeComponent();

        BindingContext = catalogsProductConsultViewModel;
    }
}