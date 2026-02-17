namespace TextileSystem.ViewModels;

public partial class AuthPageViewModel(IWindowService windowService, IShellService shellService) : ObservableObject {

    [ObservableProperty]
    public partial bool IsBusy { get; set; }

    [RelayCommand]
    async Task SignIn() {

        var idiom = DeviceInfo.Idiom;

        IsBusy = true;

        await Task.Delay(2000); // Simulate sign-in process

        if(idiom == DeviceIdiom.Desktop) {

            await shellService.NavigateToAsync($"//{nameof(MainPage)}");

            windowService.MaximizeCurrentWindow();

        } else if(idiom == DeviceIdiom.Phone) {
            await shellService.DisplayAlertAsync("Notice", "Sign-in is not available on Phone devices.", "OK");
        }

        IsBusy = false;

    }
}
