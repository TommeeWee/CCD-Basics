namespace CSVViewer.Operations;

public class KopfzeilenExtraktor : IKopfzeilenExtraktor
{
    public string Extrahiere(string[] dateiinhalt)
    {
        return dateiinhalt[0];
    }
}