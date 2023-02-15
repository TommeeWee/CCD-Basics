// See https://aka.ms/new-console-template for more information

using System.Text;
using CSVViewer.Integrations;
using CSVViewer.Operations;

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

        var kommandos = new IEingabeKommando []
        {
            new FirstPageEingabeKommando(),
            new PrevPageEingabeKommando(),
            new NextPageEingabeKommando(),
            new LastPageEingabeKommando(),
            new ExitEingabeKommando()
        };
        
        var eingabeInterpreter = new EingabeInterpreter(kommandos);

        var aktuelleSeite = 1;

        do
        {
            seitenanzeige.ZeigeSeite(dateiname, aktuelleSeite);
            eingabeInterpreter.ZeigeKommandos();
            var kommando = eingabeInterpreter.NaechstesKommando();
            aktuelleSeite = kommando.Ausfuehren(aktuelleSeite);
        } while (aktuelleSeite > 0);
        
    }
}