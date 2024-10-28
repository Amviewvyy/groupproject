using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2011Repository
    {
        Task<Mlb2011ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2011ViewModel> GetAllAsync();

        Task AddAsync(Mlb2011ViewModel mlb2011);
        Task UpdateAsync(Mlb2011ViewModel mlb2011);
        Task DeleteAsync(int Id);
        Task<List<Mlb2011ViewModel>> GetAllAsListAsync();
    }
}
