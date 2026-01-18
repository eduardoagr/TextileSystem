namespace TextileSystem.Controls;

public partial class CustomButton : Button {

    public CustomButton() {

        // Add the TouchBehavior automatically
        var touch = new TouchBehavior {

            DefaultBackgroundColor = Colors.Transparent,
            HoveredBackgroundColor = Colors.Green,
        };

        Behaviors.Add(touch);
    }

}
