namespace TextileSystem.MenuViews;

public partial class CatalogsUsersConsult : ContentPage
{
    public CatalogsUsersConsult(CatalogsUsersConsultViewModel usersConsultViewModel)
    {
        InitializeComponent();

        BindingContext = usersConsultViewModel;
    }
}