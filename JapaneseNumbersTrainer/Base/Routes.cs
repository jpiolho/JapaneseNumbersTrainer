namespace JapaneseNumbersTrainer.Base;

public static class Routes
{
    public const string MainMenu = "/";
    
    public const string NormalNumbersMenu = "/normal-numbers";
    public const string NormalNumbersNumberToJapanese = $"/{NormalNumbersMenu}/number-to-japanese";
    public const string NormalNumbersOptions = $"/{NormalNumbersMenu}/options";
    public const string NormalNumbersTranslate = $"/{NormalNumbersMenu}/translate";

    public const string DatesMenu = "/dates";
    public const string DatesWeekdays = $"/{DatesMenu}/weekdays";
    public const string DatesMonths = $"/{DatesMenu}/months";
    public const string DatesDays = $"/{DatesMenu}/days";
    public const string DatesFullDate = $"/{DatesMenu}/full-date";

}
