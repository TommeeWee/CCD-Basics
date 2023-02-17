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
        formattedPage = AppendLine(formattedPage, LineFormatter.Format(page.Header, columnLengths, FieldPadding, FieldDelimiter));

        var headerSeparator = CreateHeaderSeparator(page);

        formattedPage = AppendLine(formattedPage, LineFormatter.Format(
            headerSeparator,
            columnLengths,
            HeaderSeparationPadding,
            HeaderSeparationDelimiter));

        foreach (var line in page.Content)
            formattedPage = AppendLine(formattedPage, LineFormatter.Format(line, columnLengths, FieldPadding, FieldDelimiter));

        formattedPage = AppendLine(formattedPage, PageSummary(page.PageNo, page.TotalPages));
        return formattedPage;
    }

    private static string PageSummary(int pageNo, int totalPages)
    {
        return $"Page {pageNo} of {totalPages}";
    }

    private static CsvLine CreateHeaderSeparator(CsvPage page)
    {
        return new CsvLine(Enumerable
            .Range(0, page.FieldCount)
            .Select(i => string.Empty)
            .ToArray());
    }

    private static int[] GetColumnLengths(CsvPage page)
    {
        var lengths = new int[page.FieldCount];

        for (var i = 0; i < page.FieldCount; i++)
            lengths[i] = GetColumnLength(page, i);

        return lengths;
    }

    private static int GetColumnLength(CsvPage page, int column)
    {
        var headerLength = page.Header.Fields[column].Length;
        var maxColumnLength = page.Content.Max(line => line.Fields[column].Length);

        if (headerLength > maxColumnLength)
            return headerLength;

        return maxColumnLength;
    }

    private static string AppendLine(string text, string newLine)
    {
        return text + newLine + Environment.NewLine;
    }
}