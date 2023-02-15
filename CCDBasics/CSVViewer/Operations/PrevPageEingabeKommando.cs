namespace CSVViewer.Operations;

public class PrevPageEingabeKommando : IEingabeKommando
{
    public string Caption => "P)revious page";
    public char Eingabe => 'P';

    public int Ausfuehren(int aktuelleSeite, int seitenanzahl)
    {
        if (aktuelleSeite > 1)
            return aktuelleSeite - 1;
        return 1;
    }
}