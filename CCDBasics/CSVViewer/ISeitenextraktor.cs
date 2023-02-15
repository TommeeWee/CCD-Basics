namespace CSVViewer;

public interface ISeitenextraktor
{
    string[] LadeSeite(string[] dateiinhalt, int seite);
}