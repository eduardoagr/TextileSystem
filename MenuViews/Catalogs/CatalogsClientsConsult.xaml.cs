namespace TextileSystem.MenuViews;

public partial class CatalogsClientsConsult : ContentPage
{
    public CatalogsClientsConsult(CatalogsClientsConsultViewModel clientsConsultViewModel)
    {
        InitializeComponent();

        BindingContext = clientsConsultViewModel;
    }
}