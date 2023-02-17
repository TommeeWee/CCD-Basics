namespace CSVViewer;

public static class PageExtractor
{
    public static CsvPage GetPage(string[][] csvFileContent, int pageSize, int currentPage)
    {
        var header = csvFileContent[0];
        var content = InternalGetPage(csvFileContent, pageSize, currentPage).ToArray();

        return new CsvPage(header, content);
    }

    private static IEnumerable<string[]> InternalGetPage(string[][] csvFileContent, int pageSize, int currentPage)
    {
        var offset = 1 + ((currentPage - 1) * pageSize);

        var lastEntry = offset + pageSize - 1;
        if (lastEntry > csvFileContent.Length)
            lastEntry = csvFileContent.Length - 1;

        for (var i = offset; i <= lastEntry; i++)
            yield return csvFileContent[i];
    }
}