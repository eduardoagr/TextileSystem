namespace TextileSystem.Interfaces;

public interface ICustomDialogService {

    void Show(string imageSource, string message = "Guardado satisfactoriamente");

    void Hide();
}
