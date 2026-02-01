namespace TextileSystem.Models;

public partial class UISettingItems(string code, string display) : ObservableObject {

    public string Code { get; } = code;

    [ObservableProperty]
    public partial string Display { get; set; } = display;

    public override string ToString() => Display;

}
