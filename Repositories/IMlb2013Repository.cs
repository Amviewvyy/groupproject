using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2013Repository
    {
        Task<Mlb2013ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2013ViewModel> GetAllAsync();

        Task AddAsync(Mlb2013ViewModel mlb2013);
        Task UpdateAsync(Mlb2013ViewModel mlb2013);
        Task DeleteAsync(int Id);
        Task<List<Mlb2013ViewModel>> GetAllAsListAsync();
    }
}
