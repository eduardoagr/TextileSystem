namespace TextileSystem.Helpers;

public class AppSettings
{
    private const string LanguageKey = "SelectedLanguage";
    private const string TileColorKey = "TileColor";

    public static string GetLanguage() => Preferences.Get(LanguageKey, "Spanish");

    public static void SetLanguage(string language) => Preferences.Set(LanguageKey, language);

    public static Color GetTileColor()
    {
        var hex = Preferences.Get(TileColorKey, Colors.Blue.ToHex());
        return Color.FromArgb(hex);
    }

    public static void SetTileColor(Color color) => Preferences.Set(TileColorKey, color.ToHex());

}
