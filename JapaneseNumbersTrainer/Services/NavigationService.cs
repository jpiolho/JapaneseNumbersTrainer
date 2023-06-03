using Microsoft.AspNetCore.Components;

namespace JapaneseNumbersTrainer.Services;

public class NavigationService
{
    private NavigationManager _navigationManager;

    public NavigationService(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public void Goto(string route) => _navigationManager.NavigateTo(route.Substring(1));
    public void ForceRefresh() => _navigationManager.NavigateTo("", true);

    public void ChangeQueryString(string queryString, bool forceLoad = false)
    {
        var uri = new Uri(_navigationManager.Uri);
        _navigationManager.NavigateTo($"{uri.LocalPath}?{queryString}", forceLoad);
    }
}
