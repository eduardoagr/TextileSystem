namespace TextileSystem.MenuViewModels;

public partial class CatalogsProvidersConsultViewModel(ICustomDialogService customDialogServices) : ObservableObject
{
    [ObservableProperty]
    public partial bool IsCreateProviderDialogOpen
    {
        get; set;
    }

    [ObservableProperty]
    public partial string NewProvider
    {
        get; set;
    }


    [RelayCommand]
    void CreateUserProvider()
    {
        IsCreateProviderDialogOpen = true;
    }

    [RelayCommand]
    void SaveToDatabase()
    {
        customDialogServices.Show("success.gif");
    }

    [RelayCommand]
    void ResetTexBox()
    {
        // NewProvider = string.Empty;
    }

}
