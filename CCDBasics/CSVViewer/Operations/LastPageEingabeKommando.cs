namespace CSVViewer.Operations;

public class LastPageEingabeKommando : IEingabeKommando
{
    public string Caption => "L)ast page";
    public char Eingabe => 'L';

    public int Ausfuehren(int aktuelleSeite, int seitenanzahl)
    {
        return seitenanzahl;

    }
}