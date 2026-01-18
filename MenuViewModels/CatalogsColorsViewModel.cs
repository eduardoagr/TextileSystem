namespace TextileSystem.MenuViewModels;

public partial class CatalogsColorsViewModel(ICustomDialogService dialogService) : ObservableObject {

    [RelayCommand]
    public void SaveToDatabase() {

        // Implement saving logic here

        dialogService.ShowAsync("success.gif");
    }
}
