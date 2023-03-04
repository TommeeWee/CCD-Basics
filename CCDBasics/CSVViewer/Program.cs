// See https://aka.ms/new-console-template for more information

using CSVViewer.Input;

namespace CSVViewer;

public static class Program
{
    public static void Main(string[] args)
    {
        var fileName = CommandLineArgumentInterpreter.GetFileName(args);
        var pageSize = CommandLineArgumentInterpreter.GetPageSize(args);

        var csvFile = CsvFileReader.ReadCsvFromFile(fileName);
        var pageCount = PagingHelper.GetPageCount(csvFile, pageSize);

        var model = new CsvViewerModel(csvFile, pageSize, pageCount, 1, false);
        
        while (!model.ExitApplication)
        {
            var csvPage = PageExtractor.GetPage(model);
            var formattedPage = PageFormatter.Format(csvPage);
            PagingHelper.ShowFormattedPage(formattedPage);

            InputHandler.ShowCommandList();
            var key = InputHandler.GetNextKey();
            var command = InputHandler.GetNextCommand(key);
            model = command.Execute(model);
        }
    }
}