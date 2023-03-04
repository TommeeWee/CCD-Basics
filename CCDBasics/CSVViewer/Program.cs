using CSVViewer.Input;
using CSVViewer.Models;

namespace CSVViewer;

public static class Program
{
    public static void Main(string[] args)
    {
        var fileName = CommandLineArgumentInterpreter.GetFileName(args);
        var pageSize = CommandLineArgumentInterpreter.GetPageSize(args);

        var model = LoadModel(fileName, pageSize);

        while (!model.ExitApplication)
        {
            ShowCurrentPage(model);

            model = RunNextCommand(model);
        }
    }

    private static CsvViewerModel RunNextCommand(CsvViewerModel model)
    {
        InputHandler.ShowCommandList();
        var key = InputHandler.GetNextKey();
        var command = InputHandler.GetNextCommand(key);
        model = command.Execute(model);
        return model;
    }

    private static void ShowCurrentPage(CsvViewerModel model)
    {
        var csvPage = PageExtractor.GetPage(model);
        var formattedPage = PageFormatter.Format(csvPage);
        PagingHelper.ShowFormattedPage(formattedPage);
    }

    private static CsvViewerModel LoadModel(string fileName, int pageSize)
    {
        var csvFile = CsvFileReader.ReadCsvFromFile(fileName);
        var pageCount = PagingHelper.GetPageCount(csvFile, pageSize);

        var model = new CsvViewerModel(csvFile, pageSize, pageCount, 1, false);
        return model;
    }
}