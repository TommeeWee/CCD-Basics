namespace CSVViewer;

public record CsvLine(string[] Fields)
{
    public int FieldCount => Fields.Length;
}