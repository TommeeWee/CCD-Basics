using System.Text;

namespace CSVViewer;

public static class LineFormatter
{
    public static string Format(CsvLine line, int[] columnLengths, char padding, char delimiter)
    {
        // Mit StringBuilder gibt es hier Warnungen zur Vermischung von I und O
        
        var formattedLine = string.Empty;
        for (var i = 0; i < line.Fields.Length; i++)
            formattedLine += FieldFormatter.Format(line.Fields[i], columnLengths[i], padding, delimiter);

        return formattedLine;
    }
}