namespace CSVViewer;

public record CsvPage(CsvLine Header, CsvLine[] Content)
{
    public int FieldCount => Header.FieldCount;

    public int RowCount => Content.Length;
}