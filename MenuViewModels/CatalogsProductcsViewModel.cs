namespace TextileSystem.MenuViewModels;

public partial class CatalogsProductcsViewModel(ICustomDialogService dialogService) : ObservableObject
{

    public void SetDialogService(ICustomDialogService service) => dialogService = service;


    [RelayCommand]
    public void SaveToDatabase()
    {

        // Implement saving logic here

        dialogService.ShowAsync("success.gif");
    }
}
