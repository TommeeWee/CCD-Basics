namespace CSVViewer.Input;

public class FirstPageInputInteractor : IInputInteractor
{
    public string Caption => "F)irst page";
    
    public char Eingabe => 'F';
    
    
    public int Execute(int aktuelleSeite, int seitenanzahl)
    {
        return 1;
    }
}