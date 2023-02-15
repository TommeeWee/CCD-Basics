namespace CSVViewer.Operations;

public class Seitenausgabe : ISeitenausgabe
{
    public void Ausgabe(string kopfzeile, string[] seite)
    {
        Console.WriteLine(kopfzeile);
        Console.WriteLine("----------");
        foreach (var zeile in seite)
        {
            Console.WriteLine(zeile);
        }
    }
}