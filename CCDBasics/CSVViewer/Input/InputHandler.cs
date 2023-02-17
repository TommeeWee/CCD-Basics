namespace CSVViewer.Input;

public static class InputHandler
{
    public static readonly IInputInteractor[] Commands = new IInputInteractor[]
    {
        new FirstPageInputInteractor(),
        new PrevPageInputInteractor(),
        new NextPageInputInteractor(),
        new LastPageInputInteractor(),
        new ExitInputInteractor()
    };

    public static void ShowCommandList()
    {
        var result = string.Join(", ", Commands.Select(k => k.Caption));
        Console.WriteLine(result);
    }

    public static IInputInteractor GetNextCommand()
    {
        while (true)
        {
            var key = GetNextKey();
            var kommando = Commands.FirstOrDefault(k => k.Eingabe == key);
            if (kommando != null)
            {
                Console.WriteLine();
                return kommando;
            }
        }
    }

    private static char GetNextKey()
    {
        var key = Console.ReadKey();
        Console.Write('\b');
        Console.Write(" ");
        Console.Write('\b');
        var upperCaseKey = key.KeyChar
            .ToString()
            .ToUpper()[0];

        return upperCaseKey;
    }
}