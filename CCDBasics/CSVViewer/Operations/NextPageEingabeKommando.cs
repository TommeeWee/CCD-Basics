namespace CSVViewer.Operations;

public class NextPageEingabeKommando : IEingabeKommando
{
    public string Caption => "N)ext page";
    public char Eingabe => 'N';

    public int Ausfuehren(int aktuelleSeite, int seitenanzahl)
    {
        if (aktuelleSeite < seitenanzahl)
            return aktuelleSeite + 1;
        
        return seitenanzahl;
    }
}