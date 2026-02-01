namespace TextileSystem.Services;

public class UISettingItemsServices : IUISettingItemsServices {

    public ObservableCollection<UISettingItems> GetUISettingItems(ILocalizationResourceManager loc) => [
            new("en", loc["Settings_en"]),
            new("es", loc["Settings_es"]),
            new("zh", loc["Settings_zh"]),
        ];
}



