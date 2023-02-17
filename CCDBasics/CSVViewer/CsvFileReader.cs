namespace CSVViewer;

public static class CsvFileReader
{
    private const char Delimiter = ';';

    public static string[][] Read(string fileName)
    {
        return InternalRead(fileName).ToArray();
    }

    public static IEnumerable<string[]> InternalRead(string fileName)
    {
        var lines = File.ReadLines(fileName);
        foreach (var line in lines)
            yield return line.Split(Delimiter);
    }
}