namespace TextileSystem.Controls;

public partial class AppBarButton : ContentView {

    public AppBarButton() {
        InitializeComponent();
    }

    public static readonly BindableProperty IconProperty = BindableProperty.Create(
        nameof(Icon), typeof(string), typeof(AppBarButton));

    public string Icon {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }


    public static readonly BindableProperty CaptionProperty = BindableProperty.Create(
        nameof(Caption), typeof(string), typeof(AppBarButton));

    public string Caption {
        get => (string)GetValue(CaptionProperty);
        set => SetValue(CaptionProperty, value);
    }


    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
        nameof(Command), typeof(ICommand), typeof(AppBarButton));

    public ICommand Command {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

}