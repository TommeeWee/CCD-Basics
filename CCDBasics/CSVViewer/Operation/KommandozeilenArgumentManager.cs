namespace CSVViewer.Operation;

public class KommandozeilenArgumentManager : IKommandozeilenArgumentManager
{
    private readonly int _standardSeitengroesse;

    public KommandozeilenArgumentManager(int standardSeitengroesse)
    {
        _standardSeitengroesse = standardSeitengroesse;
    }

    public string LeseDateinamen(string[] argumente)
    {
        return argumente[0];
    }

    public int LeseSeitengroesse(string[] argumente)
    {
        if (argumente.Length < 2)
            return _standardSeitengroesse;

        return int.Parse(argumente[1]);
    }
}