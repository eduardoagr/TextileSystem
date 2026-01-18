namespace TextileSystem.ViewModels.Base;

public abstract partial class ViewModelBase<T>(
    IShellService shellService, IMessenger messenger) : ObservableObject
    where T : class, INotifyPropertyChanged {

    private T? _trackedModel;
    private PropertyChangedEventHandler? _propertyChangedHandler;
    protected readonly IMessenger Messenger = messenger;

    protected void TrackModel(T model, params IRelayCommand[] commands) {
        if(_trackedModel != null && _propertyChangedHandler != null)
            _trackedModel.PropertyChanged -= _propertyChangedHandler;

        _propertyChangedHandler = (_, _) => {
            foreach(var cmd in commands)
                cmd.NotifyCanExecuteChanged();
        };

        model.PropertyChanged += _propertyChangedHandler;

        _trackedModel = model;

        foreach(var cmd in commands)
            cmd.NotifyCanExecuteChanged();
    }

    // Shell Helpers...
    protected async Task DisplayAlertAsync(string title, string message, string cancel) =>
        await shellService.DisplayAlertAsync(title, message, cancel);

    protected async Task<bool> DisplayConfirmAsync(string title, string message, string accept, string cancel) =>
        await shellService.DisplayConfirmAsync(title, message, accept, cancel);


    // Navigation helpers...
    protected async Task NavigateAsync(string route) => await shellService.NavigateToAsync(route);
    protected async Task NavigateAsync(string route, IDictionary<string, object> parameters) => await shellService.NavigateToAsync(route, parameters);
    protected async Task NavigateBackAsync() => await shellService.NavigateBackAsync();
}
