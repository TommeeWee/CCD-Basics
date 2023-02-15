namespace CSVViewer;

public class FirstPageEingabeKommando : IEingabeKommando
{
    public string Caption => "F)irst page";
    
    public char Eingabe => 'F';
    
    
    public int Ausfuehren(int aktuelleSeite)
    {
        return 1;
    }
}