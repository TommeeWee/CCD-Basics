namespace CSVViewer.Integrations;

public class CSVSeitenanzeige
{
    private readonly IDateiLeser _dateiLeser;
    private readonly IKopfzeilenExtraktor _kopfzeilenExtraktor;
    private readonly ISeitenextraktor _seitenextraktor;
    private readonly ISeitenausgabe _seitenausgabe;

    public CSVSeitenanzeige(IDateiLeser dateiLeser, IKopfzeilenExtraktor kopfzeilenExtraktor, ISeitenextraktor seitenextraktor, ISeitenausgabe seitenausgabe)
    {
        _dateiLeser = dateiLeser;
        _kopfzeilenExtraktor = kopfzeilenExtraktor;
        _seitenextraktor = seitenextraktor;
        _seitenausgabe = seitenausgabe;
    }

    public void ZeigeSeite(string dateiname, int seite)
    {
        var dateiinhalt = _dateiLeser.Lese(dateiname);
        var kopfzeile = _kopfzeilenExtraktor.Extrahiere(dateiinhalt);
        var seiteninhalt = _seitenextraktor.LadeSeite(dateiinhalt, seite);
        
        _seitenausgabe.Ausgabe(kopfzeile, seiteninhalt);
    }
}