namespace CSVViewer.Input;

public class LastPageInputInteractor : IInputInteractor
{
    public string Caption => "L)ast page";
    public char Input => 'L';
    public CsvViewerModel Execute(CsvViewerModel model)
    {
        return model with { CurrentPage = model.PageCount };
    }
}