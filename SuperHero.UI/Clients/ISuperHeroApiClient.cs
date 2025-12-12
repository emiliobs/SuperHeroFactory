using SuperHero.UI.Models;

namespace SuperHero.UI.Clients
{
    public interface ISuperHeroApiClient
    {
        Task<List<SuperHeroViewModel>> GetAllAsync();

        Task<SuperHeroViewModel?> GetByIdAsync(int id);

        Task<bool> CreateAsync(SuperHeroEditModel newSuperHero);

        Task<bool> UpdateAsync(int id, SuperHeroEditModel updatedSuperHero);

        Task<bool> DeleteAsync(int id);
    }
}