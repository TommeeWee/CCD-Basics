namespace CSVViewer;

public record CsvFile(CsvLine Header, CsvLine[] Rows)
{
    public int RowCount => Rows.Length;
}