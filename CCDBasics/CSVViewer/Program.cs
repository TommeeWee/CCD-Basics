// See https://aka.ms/new-console-template for more information

using CSVViewer.Integration;
using CSVViewer.Operation;

namespace CSVViewer;

public static class Program
{
    public static void Main(string[] args)
    {
        var kommandoZeilenArgumentManager = new KommandozeilenArgumentManager(3);
        var dateiname = kommandoZeilenArgumentManager.LeseDateinamen(args);
        var seitengroesse = kommandoZeilenArgumentManager.LeseSeitengroesse(args);

        var dateiLeser = new ZeilenweiseDateiLeser();
        var kopfzeilenextraktor = new KopfzeilenExtraktor();
        var seitenextraktor = new Seitenextraktor(seitengroesse);
        var seitenausgabe = new Seitenausgabe();
        
        var seitenanzeige = new CSVSeitenanzeige(dateiLeser, kopfzeilenextraktor, seitenextraktor, seitenausgabe);
        
        
        
        seitenanzeige.ZeigeSeite(dateiname, 1);
        Console.WriteLine();
        seitenanzeige.ZeigeSeite(dateiname, 2);
        Console.WriteLine();
        seitenanzeige.ZeigeSeite(dateiname, 3);
        Console.WriteLine();
    }
}