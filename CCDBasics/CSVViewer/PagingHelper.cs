namespace CSVViewer;

public static class PagingHelper
{
    public static int GetPageCount(CsvFile csvFile, int pageSize)
    {
        return (int)Math.Ceiling((double)(csvFile.RowCount) / pageSize);
    }

    public static bool CanShowPage(int currentPage)
    {
        return currentPage > 0;
    }

    public static void ShowFormattedPage(string formattedPage)
    {
        Console.WriteLine(formattedPage);
    }
}