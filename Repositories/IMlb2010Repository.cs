using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2010Repository
    {
        Task<Mlb2010ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2010ViewModel> GetAllAsync();

        Task AddAsync(Mlb2010ViewModel mlb2010);
        Task UpdateAsync(Mlb2010ViewModel mlb2010);
        Task DeleteAsync(int Id);
        Task<List<Mlb2010ViewModel>> GetAllAsListAsync();

    }
}
