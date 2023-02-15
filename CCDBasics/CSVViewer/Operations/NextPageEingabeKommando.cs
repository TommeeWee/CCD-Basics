namespace CSVViewer;

public class NextPageEingabeKommando : IEingabeKommando
{
    public string Caption => "N)ext page";
    public char Eingabe => 'N';

    public int Ausfuehren(int aktuelleSeite)
    {
        return 1;
    }
}