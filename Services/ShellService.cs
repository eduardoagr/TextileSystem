namespace TextileSystem.Services;

public class ShellService : IShellService {

    public async Task DisplayAlertAsync(string title, string message, string cancel)
        => await Shell.Current.DisplayAlertAsync(title, message, cancel);

    public async Task<bool> DisplayConfirmAsync(string title, string message, string accept, string cancel) =>
      await Shell.Current.DisplayAlertAsync(title, message, accept, cancel);

    public async Task NavigateToAsync(string route) => await Shell.Current.GoToAsync(route, true);

    public async Task NavigateToAsync(string route, IDictionary<string, object> parameters) => await Shell.Current.GoToAsync(route, parameters);

    public async Task NavigateBackAsync() => await Shell.Current.GoToAsync("..", true);
}