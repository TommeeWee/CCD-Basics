namespace CSVViewer;

public interface IEingabeInterpreter
{
    void ZeigeKommandos();
    IEingabeKommando NaechstesKommando();
}

public class EingabeInterpreter : IEingabeInterpreter
{
    private readonly IEingabeKommando[] _kommandos;

    public EingabeInterpreter(IEingabeKommando[] kommandos)
    {
        _kommandos = kommandos;
    }

    public void ZeigeKommandos()
    {
        var ausgabe = string.Join(", ", _kommandos.Select(k => k.Caption));
        Console.WriteLine(ausgabe);
    }

    public IEingabeKommando NaechstesKommando()
    {
        while (true)
        {
            var key = Console.ReadKey();
            Console.Write('\b');
            Console.Write(" ");
            Console.Write('\b');
            var eingabeUpperCase = key.KeyChar
                .ToString()
                .ToUpper()[0];
            var kommando = _kommandos.FirstOrDefault(k => k.Eingabe == eingabeUpperCase);
            if (kommando != null)
            {
                Console.WriteLine();
                return kommando;
            }
        }
    }
}