namespace TextileSystem.Models;

public partial class LanguageItem : ObservableObject {

    public string Code { get; }

    [ObservableProperty]
    private string display;

    public LanguageItem(string code, string display) {
        Code = code;
        Display = display;
    }

    public override string ToString() => Display;

}
