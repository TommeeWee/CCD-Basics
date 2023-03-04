using System.Xml.XPath;

namespace CSVViewer;

public static class CsvFileReader
{
    private const char Delimiter = ';';

    public static CsvFile ReadCsvFromFile(string file)
    {
        var lines = ReadLinesFromFile(file);
        var csvLines = ConvertToCsvLines(lines);
        var header = csvLines[0];
        var rows = GetRows(csvLines);

        return new CsvFile(header, rows);
    }

    private static CsvLine[] GetRows(CsvLine[] csvLines)
    {
        return csvLines.Skip(1).ToArray();
    }

    public static CsvLine[] ReadCsvLinesFromFile(string file)
    {
        var lines = ReadLinesFromFile(file);
        return ConvertToCsvLines(lines);
    }

    private static string[] ReadLinesFromFile(string fileName)
    {
        return File.ReadLines(fileName).ToArray();
    }

    private static CsvLine[] ConvertToCsvLines(string[] lines)
    {
        var result = new CsvLine[lines.Length];

        for (int i = 0; i < lines.Length; i++)
            result[i] = ConvertToLine(i, lines[i]);

        return result;
    }

    private static CsvLine ConvertToLine(int rowNo, string line)
    {
        var formattedRowNo =  FormatHelper.FormatRowNo(rowNo);
        var newLine = $"{formattedRowNo}{Delimiter}{line}";
        return new CsvLine(GetFields(newLine));
    }

    private static string[] GetFields(string line)
    {
        var fields = line.Split(Delimiter);

        for (int i = 0; i < fields.Length; i++)
        {
            fields[i] = fields[i].Trim();
        }

        return fields;
    }
}