namespace CSVViewer;

public record CsvPage(CsvLine Header, CsvLine[] Content, int PageNo, int TotalPages)
{
    public int FieldCount => Header.FieldCount;

    public int RowCount => Content.Length;
}