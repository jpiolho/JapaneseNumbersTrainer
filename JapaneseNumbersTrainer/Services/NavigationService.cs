using Microsoft.AspNetCore.Components;

namespace JapaneseNumbersTrainer.Services;

public class NavigationService
{
    private NavigationManager _navigationManager;

    private const string PathNormalNumbers = "normal-numbers";

    public NavigationService(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public void GoToMainMenu() => _navigationManager.NavigateTo("");
    public void GoToNormalNumbersMenu() => _navigationManager.NavigateTo($"{PathNormalNumbers}");
    public void GoToNormalNumbersOptions() => _navigationManager.NavigateTo($"{PathNormalNumbers}/options");
    public void GoToNormalNumbersGameModeNumberToJapanese() => _navigationManager.NavigateTo($"{PathNormalNumbers}/number-to-japanese");
    public void GoToNormalNumbersGameModeTextToNumber() => _navigationManager.NavigateTo($"{PathNormalNumbers}/text-to-number");
    public void GoToNormalNumbersGameModeSpeechToNumber() => _navigationManager.NavigateTo($"{PathNormalNumbers}/speech-to-number");



    public void ChangeQueryString(string queryString, bool forceLoad = false)
    {
        var uri = new Uri(_navigationManager.Uri);
        _navigationManager.NavigateTo($"{uri.LocalPath}?{queryString}", forceLoad);
    }
}
