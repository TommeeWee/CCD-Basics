namespace CSVViewer;

public static class PageExtractor
{
    public static CsvPage GetPage(CsvLine[] csvFileContent, int pageSize, int currentPage)
    {
        var header = csvFileContent[0];

        var offset = GetPageOffset(pageSize, currentPage);
        var lastEntry = GetLastEntry(csvFileContent.Length, offset, pageSize, currentPage);
        
        var content = InternalGetPage(csvFileContent, offset, lastEntry);

        return new CsvPage(header, content);
    }

    private static int GetLastEntry(int totalLines, int offset, int pageSize, int currentPage)
    {
        var lastEntry = offset + pageSize - 1;
        if (lastEntry > totalLines)
            lastEntry = totalLines - 1;
        
        return lastEntry;
    }

    private static int GetPageOffset(int pageSize, int currentPage)
    {
        return 1 + ((currentPage - 1) * pageSize);
    }

    private static CsvLine[] InternalGetPage(CsvLine[] csvFileContent, int offset, int lastEntry)
    {
        var result = new List<CsvLine>();

        for (var i = offset; i <= lastEntry; i++)
            result.Add(csvFileContent[i]);

        return result.ToArray();
    }
}