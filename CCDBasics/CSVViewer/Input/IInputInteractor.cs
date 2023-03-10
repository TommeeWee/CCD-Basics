using CSVViewer.Models;

namespace CSVViewer.Input;

public interface IInputInteractor
{
    string Caption { get; }
    char Input { get; }
    CsvViewerModel Execute(CsvViewerModel model);
}