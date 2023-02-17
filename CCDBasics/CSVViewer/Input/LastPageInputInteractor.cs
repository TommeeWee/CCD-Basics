namespace CSVViewer.Input;

public class LastPageInputInteractor : IInputInteractor
{
    public string Caption => "L)ast page";
    public char Eingabe => 'L';

    public int Execute(int aktuelleSeite, int seitenanzahl)
    {
        return seitenanzahl;

    }
}