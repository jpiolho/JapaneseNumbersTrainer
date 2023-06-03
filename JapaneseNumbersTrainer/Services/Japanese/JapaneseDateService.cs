using JapaneseNumbersTrainer.Base;

namespace JapaneseNumbersTrainer.Services.Japanese;

public class JapaneseDateService
{
    private IEnumerable<(DayOfWeek, string)> Weekdays = new (DayOfWeek, string)[] {
        (DayOfWeek.Monday,"getsuyoubi"),
        (DayOfWeek.Tuesday,"kayoubi"),
        (DayOfWeek.Wednesday, "suiyoubi"),
        (DayOfWeek.Thursday, "mokuyoubi"),
        (DayOfWeek.Friday, "kinyoubi"),
        (DayOfWeek.Saturday, "doyoubi"),
        (DayOfWeek.Sunday, "nichiyoubi")
    };

    private IEnumerable<(Month, string)> Months = new (Month, string)[] {
        (Month.January, "ichigatsu"),
        (Month.February, "nigatsu"),
        (Month.March, "sangatsu"),
        (Month.April, "shigatsu"),
        (Month.May, "gogatsu"),
        (Month.June, "rokugatsu"),
        (Month.July, "shichigatsu"),
        (Month.August, "hachigatsu"),
        (Month.September, "kugatsu"),
        (Month.October, "juugatsu"),
        (Month.November, "juuichigatsu"),
        (Month.December, "juunigatsu")
    };

    private Dictionary<int, string> Days = new Dictionary<int, string>()
    {
        { 1, "tsuitachi" },
        { 2, "futsuka" },
        { 3, "mikka" },
        { 4, "yokka" },
        { 5, "itsuka" },
        { 6, "muika" },
        { 7, "nanoka" },
        { 8, "youka" },
        { 9, "kokonoka" },
        { 10, "tooka" },
        { 11, "juuichinichi" },
        { 12, "juuninichi" },
        { 13, "juusanichi" },
        { 14, "juuyokka" },
        { 15, "juugonichi" },
        { 16, "juurokunichi" },
        { 17, "juushichinichi" },
        { 18, "juuhachinichi" },
        { 19, "juukunichi" },
        { 20, "hatsuka" },
        { 21, "nijuuichinichi" },
        { 22, "nijuuninichi" },
        { 23, "nijuusanichi" },
        { 24, "nijuuyokka" },
        { 25, "nijuugonichi" },
        { 26, "nijuurokunichi" },
        { 27, "nijuushichinichi" },
        { 28, "nijuuhachinichi" },
        { 29, "nijuukunichi" },
        { 30, "sanjuunichi" },
        { 31, "sanjuuichinichi" },
    };



    public string WeekdayToRomaji(DayOfWeek weekday) => Weekdays.First(w => w.Item1 == weekday).Item2;
    public string MonthToRomaji(Month month) => Months.First(w => w.Item1 == month).Item2;
    public string DayToRomaji(int day)
    {
        if(Days.TryGetValue(day,out var romaji))
            return romaji;
        
        throw new ArgumentOutOfRangeException("Invalid day value. Must be between 1 and 31.", nameof(day));
    }
}
