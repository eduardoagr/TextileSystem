namespace TextileSystem.Interfaces;

public interface IRibbonMenuBuilder
{
    IList<MenuSection> CreateMenu(ILocalizationResourceManager loc);
}
