namespace TextileSystem.MenuViews;

public partial class CatalogsProvidersConsult : ContentPage
{
    public CatalogsProvidersConsult(CatalogsProvidersConsultViewModel providersConsultViewModel)
    {
        InitializeComponent();

        BindingContext = providersConsultViewModel;
    }
}