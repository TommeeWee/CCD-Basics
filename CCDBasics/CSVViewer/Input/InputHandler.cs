namespace CSVViewer.Input;

public static class InputHandler
{
    private static readonly IInputInteractor[] Commands = new IInputInteractor[]
    {
        new FirstPageInputInteractor(),
        new PrevPageInputInteractor(),
        new NextPageInputInteractor(),
        new LastPageInputInteractor(),
        new JumpPageInputInteractor(),
        new SortPageInputInteractor(),
        new ExitInputInteractor()
    };

    public static void ShowCommandList()
    {
        var result = string.Join(", ", Commands.Select(k => k.Caption));
        Console.WriteLine(result);
    }

    public static IInputInteractor GetNextCommand(char key)
    {
        while (true)
        {
            var command = Commands.FirstOrDefault(k => k.Input == key);
            if (command != null)
            {
                Console.WriteLine();
                return command;
            }
        }
    }

    public static char GetNextKey()
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