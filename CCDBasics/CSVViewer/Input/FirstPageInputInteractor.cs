using CSVViewer.Models;

namespace CSVViewer.Input;

public class FirstPageInputInteractor : IInputInteractor
{
    public string Caption => "F)irst page";
    
    public char Input => 'F';
    public CsvViewerModel Execute(CsvViewerModel model)
    {
        return model with { CurrentPage = 1 };
    }
}