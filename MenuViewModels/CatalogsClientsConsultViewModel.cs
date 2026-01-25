namespace TextileSystem.MenuViewModels;

public partial class CatalogsClientsConsultViewModel(ICustomDialogService customDialog) : ObservableObject
{

    [ObservableProperty]
    public partial bool IsCreateClientDialogOpen
    {
        get; set;
    }

    [ObservableProperty]
    public partial string newClient
    {
        get; set;
    }


    [RelayCommand]
    void CreateNewClient()
    {
        IsCreateClientDialogOpen = true;
    }

    [RelayCommand]
    void SaveToDatabase()
    {
        customDialog.Show("success.gif");
    }

    [RelayCommand]
    void ResetTexBox()
    {
        // newClient = string.Empty;
    }


}
