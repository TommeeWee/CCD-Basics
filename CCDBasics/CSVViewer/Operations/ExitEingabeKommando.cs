namespace CSVViewer;

public class ExitEingabeKommando : IEingabeKommando
{
    public string Caption => "E)xit";
    public char Eingabe => 'E';

    public int Ausfuehren(int aktuelleSeite)
    {
        return 0;
    }
}