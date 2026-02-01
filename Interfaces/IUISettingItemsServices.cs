namespace TextileSystem.Interfaces;

public interface IUISettingItemsServices {

    ObservableCollection<UISettingItems> GetUISettingItems(ILocalizationResourceManager loc);
}
