using CSVViewer.Models;

namespace CSVViewer.Input;

public class NextPageInputInteractor : IInputInteractor
{
    public string Caption => "N)ext page";
    public char Input => 'N';
    public CsvViewerModel Execute(CsvViewerModel model)
    {
        var nextPage = GetNextPage(model.CurrentPage, model.PageCount);
        return model with { CurrentPage = nextPage };
    }


    private static int GetNextPage(int currentPage, int pageCount)
    {
        if (currentPage < pageCount)
            return currentPage + 1;
        
        return pageCount;
    }
}