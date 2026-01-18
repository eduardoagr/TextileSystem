using System.Windows.Input;

namespace TextileSystem.Controls;

public partial class BusyButton : ContentView {
    public BusyButton() {
        InitializeComponent();
    }


    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(BusyButton));

    public string Text {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }


    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
        nameof(Command), typeof(ICommand), typeof(BusyButton));

    public ICommand Command {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }


    public static readonly BindableProperty IsBusyProperty = BindableProperty.Create(
        nameof(IsBusy), typeof(bool), typeof(BusyButton), propertyChanged: OnBusyChanged);


    public bool IsBusy {
        get => (bool)GetValue(IsBusyProperty);
        set => SetValue(IsBusyProperty, value);
    }

    public bool IsNotBusy => !IsBusy;

    private static void OnBusyChanged(BindableObject bindable, object oldValue, object newValue) {
        if(bindable is BusyButton control) {
            control.OnPropertyChanged(nameof(IsNotBusy));
        }
    }


    public static readonly BindableProperty ColorProperty = BindableProperty.Create(
        nameof(Color), typeof(Color), typeof(BusyButton), Colors.White);

    public Color Color {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }

}