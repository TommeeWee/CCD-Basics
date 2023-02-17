namespace CSVViewer.Input;

public class NextPageInputInteractor : IInputInteractor
{
    public string Caption => "N)ext page";
    public char Input => 'N';

    public int Execute(int currentPage, int pageCount)
    {
        if (currentPage < pageCount)
            return currentPage + 1;
        
        return pageCount;
    }
}