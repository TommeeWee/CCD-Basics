using System.Xml.XPath;

namespace CSVViewer;

public static class CsvFileReader
{
    private const char Delimiter = ';';

    public static CsvLine[] ReadCsvLinesFromFile(string file)
    {
        var lines = ReadLinesFromFile(file);
        return ConvertToCsvLines(lines);
    }
    
    public static string[] ReadLinesFromFile(string fileName)
    {
        return File.ReadLines(fileName).ToArray();
    }
    
    public static CsvLine[] ConvertToCsvLines(string[] lines)
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
        return line.Split(Delimiter);
    }
}

