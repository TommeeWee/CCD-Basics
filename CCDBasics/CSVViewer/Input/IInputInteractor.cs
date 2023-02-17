namespace CSVViewer.Input;

public interface IInputInteractor
{
    string Caption { get; }
    char Input { get; }
    int Execute(int currentPage, int pageCount);
}