namespace CSVViewer;

public static class FieldFormatter
{
    public static string Format(string field, int length, char padding, char delimiter)
    {
        field ??= string.Empty;
        return field.PadRight(length, padding) + delimiter;
    }
}