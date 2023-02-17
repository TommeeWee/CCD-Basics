namespace CSVViewer.Input;

public class ExitInputInteractor : IInputInteractor
{
    public string Caption => "E)xit";
    public char Input => 'E';

    public int Execute(int currentPage, int pageCount)
    {
        return 0;
    }
}