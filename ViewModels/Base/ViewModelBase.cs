namespace TextileSystem.ViewModels.Base;

public abstract partial class CatalogConsultViewModel<TModel>(ICustomDialogService dialogService) : ObservableObject
    where TModel : class, new() {

    [ObservableProperty]
    public partial bool IsDialogOpen { get; set; }

    [ObservableProperty]
    public partial TModel NewItem { get; set; } = new TModel();

    [RelayCommand]
    void CreateNew() {

        IsDialogOpen = true;
        NewItem = new TModel();
    }

    [RelayCommand]
    void SaveToDatabase() {

        dialogService.Show("success.gif");
    }

    [RelayCommand]
    void ResetModel() {
        NewItem = new TModel();
    }
}