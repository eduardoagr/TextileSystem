namespace TextileSystem.Services;

public static class LanguageServices
{
    public static ObservableCollection<string> GetSupportedLanguages()
    {
        return
        [
            "English",
            "Spanish",
        ];
    }
}
