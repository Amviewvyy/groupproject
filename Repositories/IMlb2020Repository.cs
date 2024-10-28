using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2020Repository
    {
        Task<Mlb2020ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2020ViewModel> GetAllAsync();

        Task AddAsync(Mlb2020ViewModel mlb2020);
        Task UpdateAsync(Mlb2020ViewModel mlb2020);
        Task DeleteAsync(int Id);
        Task<List<Mlb2020ViewModel>> GetAllAsListAsync();
    }
}

