using JapaneseNumbersTrainer.Base;

namespace JapaneseNumbersTrainer.Services.Japanese;

public class JapaneseDateService
{
    private IEnumerable<(DayOfWeek, string)> Weekdays = new (DayOfWeek, string)[] {
        (DayOfWeek.Monday,"Getsuyoubi"),
        (DayOfWeek.Tuesday,"Kayoubi"),
        (DayOfWeek.Wednesday, "Suiyoubi"),
        (DayOfWeek.Thursday, "Mokuyoubi"),
        (DayOfWeek.Friday, "Kinyoubi"),
        (DayOfWeek.Saturday, "Doyoubi"),
        (DayOfWeek.Sunday, "Nichiyoubi")
    };

    private IEnumerable<(Months, string)> Months = new (Months, string)[] {
        (Base.Months.January, "ichigatsu"),
        (Base.Months.February, "nigatsu"),
        (Base.Months.March, "sangatsu"),
        (Base.Months.April, "shigatsu"),
        (Base.Months.May, "gogatsu"),
        (Base.Months.June, "rokugatsu"),
        (Base.Months.July, "shichigatsu"),
        (Base.Months.August, "hachigatsu"),
        (Base.Months.September, "kugatsu"),
        (Base.Months.October, "juugatsu"),
        (Base.Months.November, "juuichigatsu"),
        (Base.Months.December, "juunigatsu")
    };



    public string WeekdayToRomaji(DayOfWeek weekday) => Weekdays.First(w => w.Item1 == weekday).Item2;
    public string MonthToRomaji(Months month) => Months.First(w => w.Item1 == month).Item2;
}
