using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2015Repository
    {
        Task<Mlb2015ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2015ViewModel> GetAllAsync();

        Task AddAsync(Mlb2015ViewModel mlb2015);
        Task UpdateAsync(Mlb2015ViewModel mlb2015);
        Task DeleteAsync(int Id);
        Task<List<Mlb2015ViewModel>> GetAllAsListAsync();
    }
}
