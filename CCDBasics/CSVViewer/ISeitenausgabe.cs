namespace CSVViewer;

public interface ISeitenausgabe
{
    void Ausgabe(string kopfzeile, string[] seite);
}