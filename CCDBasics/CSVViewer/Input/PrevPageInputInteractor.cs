namespace CSVViewer.Input;

public class PrevPageInputInteractor : IInputInteractor
{
    public string Caption => "P)revious page";
    public char Input => 'P';

    public int Execute(int currentPage, int pageCount)
    {
        if (currentPage > 1)
            return currentPage - 1;
        return 1;
    }
}