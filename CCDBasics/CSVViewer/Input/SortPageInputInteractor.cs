using CSVViewer.Models;

namespace CSVViewer.Input;

public class SortPageInputInteractor : IInputInteractor
{
    public string Caption => "S)ort";
    
    public char Input => 'S';
    public CsvViewerModel Execute(CsvViewerModel model)
    {
        var columnName = ReadColumnName();
        var columnIndex = GetColumnIndex(columnName, model.File.Header);

        if (!IsValidIndex(columnIndex))
            return model;
        
        var sortedRows = SortByRowIndex(columnIndex, model.File.Rows);

        var file = model.File with { Rows = sortedRows };
        return model with { File = file };
    }

    private static bool IsValidIndex(int columnIndex)
    {
        if (columnIndex < 0)
            return false;

        return true;
    }

    private CsvLine[] SortByRowIndex(int columnIndex, CsvLine[] fileRows)
    {
        return fileRows
            .OrderBy(row => row.Fields[columnIndex])
            .ToArray();
    }

    private static int GetColumnIndex(string? columnName, CsvLine header)
    {
        for (var i = 0; i < header.FieldCount; i++)
        {
            if (header.Fields[i].ToLower() == columnName)
                return i;
        }

        return -1;
    }

    private static string? ReadColumnName()
    {
        var columnName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(columnName))
            return "";

        return columnName.ToLower();
    }
}