using System.Xml.XPath;

namespace CSVViewer;

public static class CsvFileReader
{
    private const char Delimiter = ';';

    public static CsvLine[] Read(string fileName)
    {
        var lines = File.ReadLines(fileName);

        var result = new List<CsvLine>();

        foreach (var line in lines)
            result.Add(new CsvLine(line.Split(Delimiter)));

        return result.ToArray();
    }
}