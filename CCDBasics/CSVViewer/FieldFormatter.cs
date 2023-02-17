namespace CSVViewer;

public static class FieldFormatter
{
    public static string FormatLeftAligned(string field, int length, char padding, char delimiter)
    {
        field ??= string.Empty;
        return field.PadRight(length, padding) + delimiter;
    }
    
    public static string FormatRightAligned(string field, int length, char padding, char delimiter)
    {
        field ??= string.Empty;
        return field.PadLeft(length, padding) + delimiter;
    }
}