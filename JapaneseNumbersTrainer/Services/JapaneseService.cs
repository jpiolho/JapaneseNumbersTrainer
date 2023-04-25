using System.Text;

namespace JapaneseNumbersTrainer.Services;

public class JapaneseService
{
    private static readonly Dictionary<int, string> Ones = new Dictionary<int, string>
    {
        { 0, "zero" },
        { 1, "ichi" },
        { 2, "ni" },
        { 3, "san" },
        { 4, "yon" },
        { 5, "go" },
        { 6, "roku" },
        { 7, "nana" },
        { 8, "hachi" },
        { 9, "kyuu" }
    };

    private static readonly Dictionary<int, string> Tens = new Dictionary<int, string>
    {
        { 1, "juu" },
        { 2, "ni juu" },
        { 3, "san juu" },
        { 4, "yon juu" },
        { 5, "go juu" },
        { 6, "roku juu" },
        { 7, "nana juu" },
        { 8, "hachi juu" },
        { 9, "kyuu juu" }
    };

    private static readonly Dictionary<int, string> Hundreds = new Dictionary<int, string>
    {
        { 1, "hyaku" },
        { 2, "ni hyaku" },
        { 3, "sambyaku" },
        { 4, "yon hyaku" },
        { 5, "go hyaku" },
        { 6, "roppyaku" },
        { 7, "nana hyaku" },
        { 8, "happyaku" },
        { 9, "kyuu hyaku" }
    };

    private static readonly Dictionary<int, string> Thousands = new Dictionary<int, string>
    {
        { 1, "sen" },
        { 2, "ni sen" },
        { 3, "sanzen" },
        { 4, "yon sen" },
        { 5, "go sen" },
        { 6, "roku sen" },
        { 7, "nana sen" },
        { 8, "hassen" },
        { 9, "kyuu sen" }
    };

    private static readonly Dictionary<int, string> TenThousands = new Dictionary<int, string>
    {
        { 0, "man" },
        { 1, "ichi man" },
        { 2, "ni man" },
        { 3, "samman" },
        { 4, "yomman" },
        { 5, "go man" },
        { 6, "roku man" },
        { 7, "nana man" },
        { 8, "hachi man" },
        { 9, "kyuu man" }
    };

    private static readonly Dictionary<int, string> Oku = new Dictionary<int, string>
    {
        { 0, "oku" },
        { 1, "ichi oku" },
        { 2, "ni oku" },
        { 3, "san oku" },
        { 4, "yon oku" },
        { 5, "go oku" },
        { 6, "roku oku" },
        { 7, "nana oku" },
        { 8, "hachi oku" },
        { 9, "kyuu oku" }
    };

    private static readonly Dictionary<int, string> Cho = new Dictionary<int, string>
    {
        { 0, "cho" },
        { 1, "it cho" },
        { 2, "ni cho" },
        { 3, "san cho" },
        { 4, "yon cho" },
        { 5, "go cho" },
        { 6, "roku cho" },
        { 7, "nana cho" },
        { 8, "hachi cho" },
        { 9, "kyuu cho" }
    };

    private static readonly (string, string)[] Choonpu = new (string,string)[] 
    {
        ( "aa", "ā" ),
        ( "ii", "ī" ),
        ( "ee", "ē"),
        ( "ei", "ē"),
        ( "oo", "ō"),
        ( "ou", "ō"),
        ( "uu", "ū")
    };


    private List<string> InternalConvertToJapaneseRomaji(long number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be 0 or positive");
        }

        List<string> romaji = new();

        int cho = (int)(number / 1_000_000_000_000);
        if (cho > 0)
        {
            if (Cho.ContainsKey(cho))
                romaji.Add(Cho[cho]);
            else
            {
                romaji.AddRange(InternalConvertToJapaneseRomaji(cho));
                romaji.Add(Cho[0]);
            }

            number %= 1_000_000_000_000;
        }

        int oku = (int)(number / 100_000_000);
        if (oku > 0)
        {
            if (Oku.ContainsKey(oku))
                romaji.Add(Oku[oku]);
            else
            {
                romaji.AddRange(InternalConvertToJapaneseRomaji(oku));
                romaji.Add(Oku[0]);
            }

            number %= 100_000_000;
        }

        int tenThousands = (int)(number / 10000);
        if (tenThousands > 0)
        {
            if (TenThousands.ContainsKey(tenThousands))
                romaji.Add(TenThousands[tenThousands]);
            else
            {
                romaji.AddRange(InternalConvertToJapaneseRomaji(tenThousands));
                romaji.Add(TenThousands[0]);
            }

            number %= 10000;
        }

        int thousands = (int)(number / 1000);
        if (thousands > 0)
        {
            romaji.Add(Thousands[thousands]);
            number %= 1000;
        }

        int hundreds = (int)(number / 100);
        if (hundreds > 0)
        {
            romaji.Add(Hundreds[hundreds]);
            number %= 100;
        }

        int tens = (int)(number / 10);
        if (tens > 0)
        {
            romaji.Add(Tens[tens]);
            number %= 10;
        }

        int ones = (int)(number % 10);
        if (ones > 0)
            romaji.Add(Ones[ones]);

        return romaji;
    }

    public string ConvertToJapaneseRomaji(long number, bool choonpu, bool spaces)
    {
        var sb = new StringBuilder(string.Join(' ', InternalConvertToJapaneseRomaji(number)));

        if(choonpu)
        {
            foreach(var entry in Choonpu)
                sb.Replace(entry.Item1, entry.Item2);
        }

        if (!spaces)
            sb.Replace(" ", "");

        return sb.ToString();
    }

}
