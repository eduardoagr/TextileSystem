
namespace TextileSystem.Services;

public class CustomDialogService : ICustomDialogService {

    private readonly SfPopup popup;

    public CustomDialogService() {

        popup = new SfPopup {
            AnimationMode = PopupAnimationMode.Zoom,
            AutoSizeMode = PopupAutoSizeMode.Both,
            StaysOpen = true,
            AutoCloseDuration = 800,
            ShowOverlayAlways = true,
            OverlayMode = PopupOverlayMode.Blur,
            ShowHeader = false,
            PopupStyle = new PopupStyle {

                CornerRadius = 16
                // Background will be set dynamically in ShowAsync
            }
        };
    }


    public void HideAsync() {

        popup.Dismiss();

    }

    public void ShowAsync(string imageSource, string message = "Guardado satisfactoriamente") {


        // Update background based on current theme
        popup.PopupStyle.PopupBackground = Application.Current!.RequestedTheme == AppTheme.Dark
            ? Colors.Black
            : Colors.White;

        // Update content with custom message and image

        Image img = new() { Source = imageSource, IsAnimationPlaying = true };
        if(DeviceInfo.Idiom == DeviceIdiom.Desktop) {
            img.HeightRequest = 100;
            img.WidthRequest = 100;
        }

        popup.ContentTemplate = new DataTemplate(() => {
            return new VerticalStackLayout {

                Padding = 10,
                Children = { img, new Label { Text = message, FontAttributes = FontAttributes.Bold, FontSize = 18,
                    HorizontalTextAlignment = TextAlignment.Center }

                    }
            };
        });

        popup.Show();

    }
}