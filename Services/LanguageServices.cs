namespace TextileSystem.Services;

public static class LanguageServices {

    public static ObservableCollection<LanguageItem> GetSupportedLanguages(ILocalizationResourceManager loc) => [
            new LanguageItem("en", loc["Settings_en"]),
            new LanguageItem("es", loc["Settings_es"])

        ];
}



