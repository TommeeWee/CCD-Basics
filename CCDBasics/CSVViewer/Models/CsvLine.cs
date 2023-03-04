namespace CSVViewer.Models;

public record CsvLine(string[] Fields)
{
    public int FieldCount => Fields.Length;
}