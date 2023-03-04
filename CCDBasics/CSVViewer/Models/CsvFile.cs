namespace CSVViewer.Models;

public record CsvFile(CsvLine Header, CsvLine[] Rows)
{
    public int RowCount => Rows.Length;
}