namespace CSVViewer;

public static class CommandLineArgumentInterpreter
{
    private const int DefaultPageSize = 3;


    public static string GetFileName(string[] arguments)
    {
        return arguments[0];
    }

    public static int GetPageSize(string[] arguments)
    {
        if (arguments.Length < 2)
            return DefaultPageSize;

        return int.Parse(arguments[1]);
    }
}