namespace CSVViewer.Input;

public class ExitInputInteractor : IInputInteractor
{
    public string Caption => "E)xit";
    public char Input => 'E';
    public CsvViewerModel Execute(CsvViewerModel model)
    {
        return model with { ExitApplication = true};
    }
}