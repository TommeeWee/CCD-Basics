namespace CSVViewer;

public static class CommandLineArgumentInterpreter
{
    private const int DefaultPageSize = 3;


    public static string GetFileName(string[] argumente)
    {
        return argumente[0];
    }

    public static int GetPageSize(string[] argumente)
    {
        if (argumente.Length < 2)
            return DefaultPageSize;

        return int.Parse(argumente[1]);
    }
}