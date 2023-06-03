using Blazored.LocalStorage;

namespace JapaneseNumbersTrainer.Services.Options;

public class OptionsService
{
    private ILocalStorageService _localStorage;

    public OptionsService(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public async Task<AppOptions> GetOptionsAsync()
    {
        var options = await _localStorage.GetItemAsync<AppOptions>("options");
        return options ?? new AppOptions();
    }

    public async Task SetOptionsAsync(AppOptions options)
    {
        await _localStorage.SetItemAsync("options", options);
    }
}
