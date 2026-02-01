namespace TextileSystem.Services;

public static class UISettingItemsServices {

    public static ObservableCollection<UISettingItems> GetUISettingItems(ILocalizationResourceManager loc) => [
            new("en", loc["Settings_en"]),
            new("es", loc["Settings_es"]),
            new("zh", loc["Settings_zh"]),
        ];
}



