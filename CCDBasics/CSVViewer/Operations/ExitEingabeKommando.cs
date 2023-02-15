namespace CSVViewer.Operations;

public class ExitEingabeKommando : IEingabeKommando
{
    public string Caption => "E)xit";
    public char Eingabe => 'E';

    public int Ausfuehren(int aktuelleSeite, int seitenanzahl)
    {
        return 0;
    }
}