using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2018Repository
    {
        Task<Mlb2018ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2018ViewModel> GetAllAsync();

        Task AddAsync(Mlb2018ViewModel mlb2018);
        Task UpdateAsync(Mlb2018ViewModel mlb2018);
        Task DeleteAsync(int Id);
        Task<List<Mlb2018ViewModel>> GetAllAsListAsync();
    }
}

