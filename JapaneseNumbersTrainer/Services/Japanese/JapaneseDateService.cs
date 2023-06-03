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



    public string WeekdayToRomaji(DayOfWeek weekday) => Weekdays.First(w => w.Item1 == weekday).Item2;
    public string MonthToRomaji(Month month) => Months.First(w => w.Item1 == month).Item2;
}
