// See https://aka.ms/new-console-template for more information

using CSVViewer.Input;

namespace CSVViewer;

public static class Program
{
    public static void Main(string[] args)
    {
        var fileName = CommandLineArgumentInterpreter.GetFileName(args);
        var pageSize = CommandLineArgumentInterpreter.GetPageSize(args);

        var csvFileContent = CsvFileReader.Read(fileName);
        var pageCount = PagingHelper.GetPageCount(csvFileContent, pageSize);

        var currentPage = 1;

        while (PagingHelper.CanShowPage(currentPage))
        {
            var csvPage = PageExtractor.GetPage(csvFileContent, pageSize, currentPage);
            var formattedPage = PageFormatter.Format(csvPage);
            PagingHelper.ShowFormattedPage(formattedPage);

            InputHandler.ShowCommandList();
            var key = InputHandler.GetNextKey();
            var command = InputHandler.GetNextCommand(key);
            currentPage = command.Execute(currentPage, pageCount);
        }
    }
}