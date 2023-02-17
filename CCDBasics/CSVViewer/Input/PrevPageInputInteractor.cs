namespace CSVViewer.Input;

public class PrevPageInputInteractor : IInputInteractor
{
    public string Caption => "P)revious page";
    public char Eingabe => 'P';

    public int Execute(int aktuelleSeite, int seitenanzahl)
    {
        if (aktuelleSeite > 1)
            return aktuelleSeite - 1;
        return 1;
    }
}