namespace CSVViewer;

public interface IEingabeKommando
{
    string Caption { get; }
    char Eingabe { get; }

    int Ausfuehren(int aktuelleSeite);
}