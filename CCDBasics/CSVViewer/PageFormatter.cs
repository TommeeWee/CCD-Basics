using System.Text;

namespace CSVViewer;

public static class PageFormatter
{
    private const char FieldPadding = ' ';
    private const char FieldDelimiter = '|';
    private const char HeaderSeparationPadding = '-';
    private const char HeaderSeparationDelimiter = '+';

    public static string Format(CsvPage page)
    {
        var columnLengths = GetColumnLengths(page);

        var formattedPage = string.Empty;
        formattedPage += LineFormatter.Format(page.Header, columnLengths, FieldPadding, FieldDelimiter);

        var headerSeparator = CreateHeaderSeparator(page);

        formattedPage += LineFormatter.Format(
            headerSeparator,
            columnLengths,
            HeaderSeparationPadding,
            HeaderSeparationDelimiter);

        foreach (var line in page.Content)
            formattedPage += LineFormatter.Format(line, columnLengths, FieldPadding, FieldDelimiter);

        return formattedPage;
    }

    private static string[] CreateHeaderSeparator(CsvPage page)
    {
        return Enumerable
            .Range(0, page.Header.Length)
            .Select(i => string.Empty)
            .ToArray();
    }

    private static int[] GetColumnLengths(CsvPage page)
    {
        var lengths = new List<int>();

        for (var i = 0; i < page.Header.Length; i++)
        {
            lengths.Add(GetColumnLength(page, i));
        }

        return lengths.ToArray();
    }

    private static int GetColumnLength(CsvPage page, int column)
    {
        var headerLength = page.Header[column].Length;
        var maxColumnLength = page.Content.Max(line => line[column].Length);

        if (headerLength > maxColumnLength)
            return headerLength;

        return maxColumnLength;
    }
}