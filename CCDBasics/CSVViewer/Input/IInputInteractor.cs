namespace CSVViewer.Input;

public interface IInputInteractor
{
    string Caption { get; }
    char Eingabe { get; }
    int Execute(int aktuelleSeite, int seitenanzahl);
}