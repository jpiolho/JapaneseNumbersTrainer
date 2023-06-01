namespace JapaneseNumbersTrainer.Services.Japanese;

public class JapaneseWeekdaysService
{
    private class WeekdayEntry
    {
        public DayOfWeek DayOfWeek { get; set; }
        public string Romaji { get; set; }

        public WeekdayEntry(DayOfWeek dayOfWeek, string romaji)
        {
            DayOfWeek = dayOfWeek;
            Romaji = romaji;
        }
    }

    private IEnumerable<WeekdayEntry> Weekdays = new WeekdayEntry[] {
        new(DayOfWeek.Monday,"Getsuyoubi"),
        new(DayOfWeek.Tuesday,"Kayoubi"),
        new(DayOfWeek.Wednesday,"Suiyoubi"),
        new(DayOfWeek.Thursday,"Mokuyoubi"),
        new(DayOfWeek.Friday,"Kinyoubi"),
        new(DayOfWeek.Saturday,"Doyoubi"),
        new(DayOfWeek.Sunday,"Nichiyoubi")
    };

    public string WeekdayToRomaji(DayOfWeek weekday) => Weekdays.First(w => w.DayOfWeek == weekday).Romaji;
}
