using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public interface IMlb2012Repository
    {
        Task<Mlb2012ViewModel> GetByIdAsync(int id);
        IQueryable<Mlb2012ViewModel> GetAllAsync();

        Task AddAsync(Mlb2012ViewModel mlb2012);
        Task UpdateAsync(Mlb2012ViewModel mlb2012);
        Task DeleteAsync(int Id);
        Task<List<Mlb2012ViewModel>> GetAllAsListAsync();
    }
}
