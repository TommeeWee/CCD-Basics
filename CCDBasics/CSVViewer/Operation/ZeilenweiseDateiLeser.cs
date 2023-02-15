using System.Text;

namespace CSVViewer.Operation;

public class ZeilenweiseDateiLeser : IDateiLeser
{
    public string[] Lese(string dateiname)
    {
        return File.ReadAllLines(dateiname, Encoding.UTF8);
    }
}