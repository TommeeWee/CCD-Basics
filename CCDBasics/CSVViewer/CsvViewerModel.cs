namespace CSVViewer;

public record CsvViewerModel(
    CsvFile File,
    int PageSize,
    int PageCount,
    int CurrentPage,
    bool ExitApplication 
    );