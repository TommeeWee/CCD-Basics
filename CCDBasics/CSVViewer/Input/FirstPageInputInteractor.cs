namespace CSVViewer.Input;

public class FirstPageInputInteractor : IInputInteractor
{
    public string Caption => "F)irst page";
    
    public char Input => 'F';
    
    
    public int Execute(int currentPage, int pageCount)
    {
        return 1;
    }
}