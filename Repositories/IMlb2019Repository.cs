using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2019Repository
    {
        Task<Mlb2019ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2019ViewModel> GetAllAsync();

        Task AddAsync(Mlb2019ViewModel mlb2019);
        Task UpdateAsync(Mlb2019ViewModel mlb2019);
        Task DeleteAsync(int Id);
        Task<List<Mlb2019ViewModel>> GetAllAsListAsync();
    }
}

