namespace CSVViewer;

public static class PagingHelper
{
    public static int GetPageCount(CsvLine[] csvFileContent, int pageSize)
    {
        return (int)Math.Ceiling((double)(csvFileContent.Length - 1) / pageSize);
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