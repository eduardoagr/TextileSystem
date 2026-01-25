namespace TextileSystem.MenuViewModels;

public partial class CatalogsProductConsultViewModel(ICustomDialogService customDialogService) : ObservableObject
{

    [ObservableProperty]
    public partial bool IsCreateProductDialogOpen
    {
        get; set;
    }

    [ObservableProperty]
    public partial string NewProduct
    {
        get; set;
    }


    [RelayCommand]
    void CreateNewColor()
    {
        IsCreateProductDialogOpen = true;
    }

    [RelayCommand]
    void SaveToDatabase()
    {
        customDialogService.Show("success.gif");
    }

    [RelayCommand]
    void ResetTexBox()
    {
        NewProduct = string.Empty;
    }
}
