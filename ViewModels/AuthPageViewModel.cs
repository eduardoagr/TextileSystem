namespace TextileSystem.ViewModels;

public partial class AuthPageViewModel : ObservableObject {

    [RelayCommand]
    async Task SignIn() {

        var idiom = DeviceInfo.Idiom;

        if(idiom == DeviceIdiom.Desktop) {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        } else if(idiom == DeviceIdiom.Phone) {
            await Shell.Current.DisplayAlertAsync("Notice", "Sign-in is not available on Phone devices.", "OK");
        }

    }
}
