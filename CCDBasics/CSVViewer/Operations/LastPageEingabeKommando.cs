namespace CSVViewer;

public class LastPageEingabeKommando : IEingabeKommando
{
    public string Caption => "L)ast page";
    public char Eingabe => 'L';

    public bool AusfuehrungFortsetzen => true;
    public int Ausfuehren(int aktuelleSeite)
    {return 1;
        
    }
}