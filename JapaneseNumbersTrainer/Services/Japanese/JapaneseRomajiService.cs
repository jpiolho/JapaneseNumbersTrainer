using System.Text;

namespace JapaneseNumbersTrainer.Services.Japanese;

public class JapaneseRomajiService
{

    private static readonly (string, string)[] Choonpu = new (string, string)[]
    {
        ( "aa", "ā" ),
        ( "ii", "ī" ),
        ( "ee", "ē"),
        ( "ei", "ē"),
        ( "oo", "ō"),
        ( "ou", "ō"),
        ( "uu", "ū")
    };

    public string ToChoonpu(string romaji) => ToChoonpu(new StringBuilder(romaji)).ToString();
    public StringBuilder ToChoonpu(StringBuilder stringBuilder)
    {
        foreach (var entry in Choonpu)
            stringBuilder.Replace(entry.Item1, entry.Item2);

        return stringBuilder;
    }

}
