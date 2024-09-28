using BlazorApp1.Layout.Models;
using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AccidenteService
{
    private readonly ILocalStorageService _localStorage;
    private const string StorageKey = "accidentes";

    public AccidenteService(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public async Task<List<Accidente>> GetAccidentesAsync()
    {
        return await _localStorage.GetItemAsync<List<Accidente>>(StorageKey) ?? new List<Accidente>();
    }

    public async Task SaveAccidenteAsync(Accidente accidente)
    {
        var accidentes = await GetAccidentesAsync();
        accidentes.Add(accidente);
        await _localStorage.SetItemAsync(StorageKey, accidentes);
    }

    public async Task DeleteAccidenteAsync(Accidente accidente)
    {
        var accidentes = await GetAccidentesAsync();
        accidentes.Remove(accidente);
        await _localStorage.SetItemAsync(StorageKey, accidentes);
    }
}

