namespace CSVViewer.Input;

public class LastPageInputInteractor : IInputInteractor
{
    public string Caption => "L)ast page";
    public char Input => 'L';

    public int Execute(int currentPage, int pageCount)
    {
        return pageCount;

    }
}