namespace CSVViewer;

public class PrevPageEingabeKommando : IEingabeKommando
{
    public string Caption => "P)revious page";
    public char Eingabe => 'P';

    public int Ausfuehren(int aktuelleSeite)
    {
        return 1;
    }
}