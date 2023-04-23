using CurrieTechnologies.Razor.SweetAlert2;

namespace JapaneseNumbersTrainer.Services;

public class DialogsService
{
    private SweetAlertService _swal;

    public DialogsService(SweetAlertService swal)
    {
        _swal = swal;
    }

    public async Task SuccessAsync(string message)
    {
        await _swal.FireAsync("Success", message, SweetAlertIcon.Success);
    }
    public async Task ErrorAsync(string message)
    {
        await _swal.FireAsync("Error", message, SweetAlertIcon.Error);
    }
}
