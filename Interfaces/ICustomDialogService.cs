namespace TextileSystem.Interfaces;

public interface ICustomDialogService {

    void ShowAsync(string imageSource, string message = "Guardado satisfactoriamente");

    void HideAsync();
}
