namespace CSVViewer.Operation;

public class KopfzeilenExtraktor : IKopfzeilenExtraktor
{
    public string Extrahiere(string[] dateiinhalt)
    {
        return dateiinhalt[0];
    }
}