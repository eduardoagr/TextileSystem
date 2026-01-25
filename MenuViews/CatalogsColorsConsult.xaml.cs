namespace TextileSystem.MenuViews;

public partial class CatalogsColorsConsult : ContentPage
{
    public CatalogsColorsConsult(CatalogsColorsConsultViewModel consultViewModel)
    {
        InitializeComponent();

        BindingContext = consultViewModel;
    }
}