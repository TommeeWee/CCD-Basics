namespace CSVViewer;

public static class FormatHelper
{
    public static string FormatRowNo(int i)
    {
        if (i == 0)
            return "No.";

        return i.ToString() + ".";
    }
}