using SuperHero.UI.Models;
using System.Net.Http.Json;

namespace SuperHero.UI.Clients;

public class SuperHeroApiClient : ISuperHeroApiClient
{
    private readonly HttpClient _httpClient;

    public SuperHeroApiClient(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    public async Task<List<SuperHeroViewModel>> GetAllAsync()
    {
        var heroes = await _httpClient.GetFromJsonAsync<List<SuperHeroViewModel>>("api/Toys");

        return heroes ?? new List<SuperHeroViewModel>();
    }

    public async Task<SuperHeroViewModel?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<SuperHeroViewModel>($"api/Toys/{id}");
    }

    public async Task<bool> CreateAsync(SuperHeroEditModel newSuperHero)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Toys", newSuperHero);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(int id, SuperHeroEditModel updatedSuperHero)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/Toys/{id}", updatedSuperHero);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"api/Toys/{id}");
        return response.IsSuccessStatusCode;
    }
}