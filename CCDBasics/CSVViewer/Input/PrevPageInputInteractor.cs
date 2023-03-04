namespace CSVViewer.Input;

public class PrevPageInputInteractor : IInputInteractor
{
    public string Caption => "P)revious page";
    public char Input => 'P';
    public CsvViewerModel Execute(CsvViewerModel model)
    {
        var prevPage = GetPrevPage(model.CurrentPage, model.PageCount);
        return model with { CurrentPage = prevPage };
    }

    private static int GetPrevPage(int currentPage, int pageCount)
    {
        if (currentPage > 1)
            return currentPage - 1;
        return 1;
    }
}