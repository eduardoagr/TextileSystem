namespace TextileSystem.MenuViewModels;

public partial class CatalogsUsersConsultViewModel(ICustomDialogService customDialogService) : ObservableObject
{

    [ObservableProperty]
    public partial bool IsCreateUsersDialogOpen
    {
        get; set;
    }

    [ObservableProperty]
    public partial string NewUser
    {
        get; set;
    }


    [RelayCommand]
    void CreateUserColor()
    {
        IsCreateUsersDialogOpen = true;
    }

    [RelayCommand]
    void SaveToDatabase()
    {
        customDialogService.Show("success.gif");
    }

    [RelayCommand]
    void ResetTexBox()
    {
        // NewUser = string.Empty;
    }

}
