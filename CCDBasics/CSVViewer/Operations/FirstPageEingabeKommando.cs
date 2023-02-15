namespace CSVViewer.Operations;

public class FirstPageEingabeKommando : IEingabeKommando
{
    public string Caption => "F)irst page";
    
    public char Eingabe => 'F';
    
    
    public int Ausfuehren(int aktuelleSeite, int seitenanzahl)
    {
        return 1;
    }
}