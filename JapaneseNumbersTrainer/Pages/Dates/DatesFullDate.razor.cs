using JapaneseNumbersTrainer.Base;
using Microsoft.AspNetCore.Components;

namespace JapaneseNumbersTrainer.Pages.Dates;

public partial class DatesFullDate
{
    [Parameter, SupplyParameterFromQuery] public int? Day { get; set; }
    [Parameter, SupplyParameterFromQuery] public int? Month { get; set; }
    [Parameter, SupplyParameterFromQuery] public int? Year { get; set; }

    private bool _validParameters = false;
    private string? _romaji;
    private bool _showRomaji;

    protected override Task OnInitializedAsync()
    {
        if (Day is null || Month is null || Year is null)
            NavigateToRandomDate();

        return Task.CompletedTask;
    }

    protected override void OnParametersSet()
    {
        if (Day is not null && Month is not null && Year is not null)
        {
            _validParameters = true;
            _romaji = $"{JapaneseNumberService.ConvertToJapaneseRomaji(Year.Value, true, false)}sen {JapaneseDateService.MonthToRomaji((Month)Month.Value)} {JapaneseDateService.DayToRomaji(Day.Value)}";
        }
    }

    private void NavigateToRandomDate()
    {
        _showRomaji = false;

        var year = Utils.GetNewRandomInt(1900, 2031, Year);
        var month = Utils.GetNewRandomInt(1, 13, Month);
        var day = Utils.GetNewRandomInt(1, 32, Day);

        NavigationService.ChangeQueryString($"{nameof(Day)}={day}&{nameof(Month)}={month}&{nameof(Year)}={year}");
    }

    private void NavigateToMenu()
    {
        NavigationService.Goto(Routes.DatesMenu);
    }
}
