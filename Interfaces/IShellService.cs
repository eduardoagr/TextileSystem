namespace TextileSystem.Interfaces;

public interface IShellService {

    Task DisplayAlertAsync(string title, string message, string cancel);

    Task<bool> DisplayConfirmAsync(string title, string message, string accept, string cancel);

    Task NavigateToAsync(string route);

    Task NavigateToAsync(string route, IDictionary<string, object> parameters);

    Task NavigateBackAsync();
}
