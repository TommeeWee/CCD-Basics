namespace CSVViewer.Input;

public class NextPageInputInteractor : IInputInteractor
{
    public string Caption => "N)ext page";
    public char Eingabe => 'N';

    public int Execute(int aktuelleSeite, int seitenanzahl)
    {
        if (aktuelleSeite < seitenanzahl)
            return aktuelleSeite + 1;
        
        return seitenanzahl;
    }
}