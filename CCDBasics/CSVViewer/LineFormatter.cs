using System.Text;

namespace CSVViewer;

public static class LineFormatter
{
    public static string Format(string[] column, int[] columnLengths, char padding, char delimiter)
    {
        var formattedLine = new StringBuilder();
        for (var i = 0; i < column.Length; i++)
            formattedLine.Append(FieldFormatter.Format(column[i], columnLengths[i], padding, delimiter));


        return formattedLine.ToString();
    }
}