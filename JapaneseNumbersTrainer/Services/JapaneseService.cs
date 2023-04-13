namespace JapaneseNumbersTrainer.Services
{


    public class JapaneseService
    {
        private static Dictionary<int, string> japaneseDigits = new() {
        { 0, "zero" },
        { 1, "ichi" },
        { 2, "ni" },
        { 3, "san" },
        { 4, "yon" },
        { 5, "go" },
        { 6, "roku" },
        { 7, "nana" },
        { 8, "hachi" },
        { 9, "kyuu" },
        { 10, "juu" },
        { 100, "hyaku" },
        { 300, "sanbyaku" },
        { 600, "roppyaku" },
        { 800, "happyaku" },
        { 1_000, "sen" },
        { 3_000, "sanzen" },
        { 8_000, "hassen" },
        { 10_000, "man" },
        { 100_000_000, "oku" }
        };

        public string ConvertToJapaneseRomaji(int number) => string.Join(' ', InternalConvertToJapaneseRomaji(number, false));

        private List<string> InternalConvertToJapaneseRomaji(int number, bool skipIchi)
        {

            if (number < 0 || number > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"Number must be between 0 and {int.MaxValue}.");
            }

            var parts = new List<string>();

            if (japaneseDigits.ContainsKey(number))
            {
                if (skipIchi && number == 1)
                    return parts;

                // Special case that after 10,000, we start adding 'ichi'
                if (number >= 10000)
                    parts.Add(japaneseDigits[1]);


                parts.Add(japaneseDigits[number]);
                return parts;
            }

            int tenThousands = number / 10000;
            if (tenThousands > 0)
            {
                parts.AddRange(InternalConvertToJapaneseRomaji(tenThousands, false));
                parts.Add(japaneseDigits[10000]);
                number %= 10000;
            }

            int thousands = number / 1000;
            if (thousands > 0)
            {
                parts.AddRange(InternalConvertToJapaneseRomaji(thousands, true));
                parts.Add(japaneseDigits[1000]);
                number %= 1000;
            }

            int hundreds = number / 100;
            if (hundreds > 0)
            {
                parts.AddRange(InternalConvertToJapaneseRomaji(hundreds, true));
                parts.Add(japaneseDigits[100]);
                number %= 100;
            }

            int tens = number / 10;
            if (tens > 0)
            {
                parts.AddRange(InternalConvertToJapaneseRomaji(tens, true));
                parts.Add(japaneseDigits[10]);
                number %= 10;
            }

            if (number > 0)
            {
                parts.Add(japaneseDigits[number]);
            }

            return parts;
        }

        private List<string> DoContractions(List<string> parts)
        {
            return parts;
        }

    }

}
