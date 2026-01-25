namespace TextileSystem.Services;

public class CustomDialogService : ICustomDialogService
{
    private readonly SfPopup _popup;
    private readonly Image _image;
    private readonly Label _messageLabel;

    public CustomDialogService()
    {
        _image = new Image
        {
            IsAnimationPlaying = true,
            HeightRequest = DeviceInfo.Idiom == DeviceIdiom.Desktop ? 100 : -1,
            WidthRequest = DeviceInfo.Idiom == DeviceIdiom.Desktop ? 100 : -1
        };

        _messageLabel = new Label
        {
            FontAttributes = FontAttributes.Bold,
            FontSize = 18,
            HorizontalTextAlignment = TextAlignment.Center
        };

        _popup = new SfPopup
        {
            AnimationMode = PopupAnimationMode.Zoom,
            AutoSizeMode = PopupAutoSizeMode.Both,
            StaysOpen = true,
            ShowOverlayAlways = true,
            OverlayMode = PopupOverlayMode.Blur,
            ShowHeader = false,
            PopupStyle = new PopupStyle { CornerRadius = 16, HasShadow = true },
            ContentTemplate = CreateContentTemplate()
        };
    }

    public void Show(string imageSource, string message = "Guardado satisfactoriamente")
    {
        UpdateTheme();

        _image.Source = imageSource;
        _messageLabel.Text = message;

        _popup.Show();
    }

    public void Hide()
    {
        _popup.Dismiss();
    }

    private void UpdateTheme()
    {
        _popup.PopupStyle.PopupBackground =
            Application.Current?.RequestedTheme == AppTheme.Dark
                ? Colors.Black
                : Colors.White;
    }

    private DataTemplate CreateContentTemplate()
    {
        return new DataTemplate(() =>
            new VerticalStackLayout
            {
                Padding = 10,
                Spacing = 12,
                Children =
                {
                    _image,
                    _messageLabel
                }
            });
    }
}
