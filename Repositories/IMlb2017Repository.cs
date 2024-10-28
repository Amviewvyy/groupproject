using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2017Repository
    {
        Task<Mlb2017ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2017ViewModel> GetAllAsync();

        Task AddAsync(Mlb2017ViewModel mlb2017);
        Task UpdateAsync(Mlb2017ViewModel mlb2017);
        Task DeleteAsync(int Id);
        Task<List<Mlb2017ViewModel>> GetAllAsListAsync();
    }
}
