namespace CSVViewer.Input;

public class ExitInputInteractor : IInputInteractor
{
    public string Caption => "E)xit";
    public char Eingabe => 'E';

    public int Execute(int aktuelleSeite, int seitenanzahl)
    {
        return 0;
    }
}