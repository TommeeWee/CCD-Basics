namespace CSVViewer.Input;

public class JumpPageInputInteractor : IInputInteractor
{
    public string Caption => "J)ump to page";
    public char Input => 'J';
    public int Execute(int currentPage, int pageCount)
    {
        var newPage = ReadNumberFromConsole();
        var pageNo = KeepNumberInBounds(newPage, pageCount);
        return pageNo; 
    }

    private static int KeepNumberInBounds(int page, int pageCount)
    {
        if (page < 1)
            return 1;

        if (page > pageCount)
            return pageCount;

        return page;
    }

    private static int ReadNumberFromConsole()
    {
        while (true)
        {
            var line = Console.ReadLine();
            if (int.TryParse(line, out var number))
                return number;
        }
    }
}