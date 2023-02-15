namespace CSVViewer.Operation;

public class Seitenextraktor : ISeitenextraktor
{
    private readonly int _seitengroesse;

    public Seitenextraktor(int seitengroesse)
    {
        _seitengroesse = seitengroesse;
    }

    public string[] LadeSeite(string[] dateiinhalt, int seite)
    {
        var offset = ((seite - 1) * _seitengroesse) + 1;
        return dateiinhalt
            .Skip(offset)
            .Take(_seitengroesse)
            .ToArray();
    }
}