using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2021Repository
    {
        Task<Mlb2021ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2021ViewModel> GetAllAsync();

        Task AddAsync(Mlb2021ViewModel mlb2021);
        Task UpdateAsync(Mlb2021ViewModel mlb2021);
        Task DeleteAsync(int Id);
        Task<List<Mlb2021ViewModel>> GetAllAsListAsync();
    }
}

