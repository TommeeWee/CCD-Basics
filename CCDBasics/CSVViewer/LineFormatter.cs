using System.Text;

namespace CSVViewer;

public static class LineFormatter
{
    public static string FormatHeader(CsvLine line, int[] columnLengths, char padding, char delimiter)
    {
        var formattedLine = string.Empty;
        for (var i = 0; i < line.Fields.Length; i++)
            formattedLine += FieldFormatter.FormatLeftAligned(line.Fields[i], columnLengths[i], padding, delimiter);

        return formattedLine;
    }
    
    public static string Format(CsvLine line, int[] columnLengths, char padding, char delimiter)
    {
        var formattedLine = string.Empty;
        formattedLine += FieldFormatter.FormatRightAligned(line.Fields[0], columnLengths[0], padding, delimiter);
        
        for (var i = 1; i < line.Fields.Length; i++)
            formattedLine += FieldFormatter.FormatLeftAligned(line.Fields[i], columnLengths[i], padding, delimiter);

        return formattedLine;
    }
}