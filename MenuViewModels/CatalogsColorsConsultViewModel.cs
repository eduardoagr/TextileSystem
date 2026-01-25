namespace TextileSystem.MenuViewModels;

public partial class CatalogsColorsConsultViewModel(ICustomDialogService customDialogService) : ObservableObject
{
    [ObservableProperty]
    public partial bool IsCreateColorDialogOpen
    {
        get; set;
    }

    [ObservableProperty]
    public partial string NewColor
    {
        get; set;
    }


    [RelayCommand]
    void CreateNewColor()
    {
        IsCreateColorDialogOpen = true;
    }

    [RelayCommand]
    void SaveToDatabase()
    {
        customDialogService.Show("success.gif");
    }

    [RelayCommand]
    void ResetTexBox()
    {
        NewColor = string.Empty;
    }
}
