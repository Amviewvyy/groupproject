using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2014Repository
    {
        Task<Mlb2014ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2014ViewModel> GetAllAsync();

        Task AddAsync(Mlb2014ViewModel mlb2014);
        Task UpdateAsync(Mlb2014ViewModel mlb2014);
        Task DeleteAsync(int Id);
        Task<List<Mlb2014ViewModel>> GetAllAsListAsync();
    }
}