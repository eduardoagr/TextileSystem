namespace TextileSystem.ViewModels;

public partial class AuthPageViewModel(IWindowService windowService) : ObservableObject {

    [ObservableProperty]
    public partial bool isBusy { get; set; }

    [RelayCommand]
    async Task SignIn() {

        var idiom = DeviceInfo.Idiom;

        isBusy = true;

        await Task.Delay(2000); // Simulate sign-in process

        if(idiom == DeviceIdiom.Desktop) {

            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");

            windowService.MaximizeCurrentWindow();

        } else if(idiom == DeviceIdiom.Phone) {
            await Shell.Current.DisplayAlertAsync("Notice", "Sign-in is not available on Phone devices.", "OK");
        }

        isBusy = false;

    }
}
