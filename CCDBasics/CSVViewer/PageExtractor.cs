using CSVViewer.Models;

namespace CSVViewer;

public static class PageExtractor
{
    public static CsvPage GetPage(CsvViewerModel model)
    {
        var offset = GetPageOffset(model.PageSize, model.CurrentPage);
        var lastEntry = GetLastEntry(model.File.RowCount, offset, model.PageSize, model.CurrentPage);
        
        var content = InternalGetPage(model.File.Rows, offset, lastEntry);

        return new CsvPage(model.File.Header, content, model.CurrentPage, model.PageCount);
    }
    public static CsvPage GetPage(CsvFile csvFile, int pageSize, int currentPage, int totalPages)
    {
        var offset = GetPageOffset(pageSize, currentPage);
        var lastEntry = GetLastEntry(csvFile.RowCount, offset, pageSize, currentPage);
        
        var content = InternalGetPage(csvFile.Rows, offset, lastEntry);

        return new CsvPage(csvFile.Header, content, currentPage, totalPages);
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
        return (currentPage - 1) * pageSize;
    }

    private static CsvLine[] InternalGetPage(CsvLine[] csvFileContent, int offset, int lastEntry)
    {
        var result = new List<CsvLine>();

        for (var i = offset; i <= lastEntry; i++)
            result.Add(csvFileContent[i]);

        return result.ToArray();
    }
}