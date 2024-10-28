using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2016Repository
    {
        Task<Mlb2016ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2016ViewModel> GetAllAsync();

        Task AddAsync(Mlb2016ViewModel mlb2016);
        Task UpdateAsync(Mlb2016ViewModel mlb2016);
        Task DeleteAsync(int Id);
        Task<List<Mlb2016ViewModel>> GetAllAsListAsync();
    }
}
