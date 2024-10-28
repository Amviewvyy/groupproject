using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ProjectDatabase.Repositories
{
    public class Mlb2011Repository : IMlb2011Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2011Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2011ViewModel mlb2011)
        {
            var newMlb2011 = new Mlb2011()
            {
                Date = mlb2011.Date,
                Rot = mlb2011.Rot,
                VH = mlb2011.VH,
                Team = mlb2011.Team,
                Pitcher = mlb2011.Pitcher,
                _1st = mlb2011._1st,
                _2nd = mlb2011._2nd,
                _3rd = mlb2011._3rd,
                _4th = mlb2011._4th,
                _5th = mlb2011._5th,
                _6th = mlb2011._6th,
                _7th = mlb2011._7th,
                _8th = mlb2011._8th,
                _9th = mlb2011._9th,
                Final = mlb2011.Final,
                Open = mlb2011.Open,
                Close = mlb2011.Close,
                OpenOU = mlb2011.OpenOU,
                column20 = mlb2011.column20,
                CloseOU = mlb2011.CloseOU,
                column22 = mlb2011.column22,
            };
            await _dbContext.Mlbs2011.AddAsync(newMlb2011);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2011 mlb2011 = await _dbContext.Mlbs2011.FindAsync(Id);
            if (mlb2011 != null)
            {
                _dbContext.Mlbs2011.Remove(mlb2011);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2011ViewModel> GetAllAsync()
        {
            var mlbs2011 = _dbContext.Mlbs2011
            .Select(e => new Mlb2011ViewModel
            {
                Id = e.Id,
                Date = e.Date,
                Rot = e.Rot,
                VH = e.VH,
                Team = e.Team,
                Pitcher = e.Pitcher,
                _1st = e._1st,
                _2nd = e._2nd,
                _3rd = e._3rd,
                _4th = e._4th,
                _5th = e._5th,
                _6th = e._6th,
                _7th = e._7th,
                _8th = e._8th,
                _9th = e._9th,
                Final = e.Final,
                Open = e.Open,
                Close = e.Close,
                OpenOU = e.OpenOU,
                column20 = e.column20,
                CloseOU = e.CloseOU,
                column22 = e.column22,
            });

            return mlbs2011;
        }

        public async Task<Mlb2011ViewModel> GetByIdAsync(int id)
        {
            var mlb2011 = await _dbContext.Mlbs2011.FindAsync(id);
            var mlb2011ViewModel = new Mlb2011ViewModel
            {
                Id = mlb2011.Id,
                Date = mlb2011.Date,
                Rot = mlb2011.Rot,
                VH = mlb2011.VH,
                Team = mlb2011.Team,
                Pitcher = mlb2011.Pitcher,
                _1st = mlb2011._1st,
                _2nd = mlb2011._2nd,
                _3rd = mlb2011._3rd,
                _4th = mlb2011._4th,
                _5th = mlb2011._5th,
                _6th = mlb2011._6th,
                _7th = mlb2011._7th,
                _8th = mlb2011._8th,
                _9th = mlb2011._9th,
                Final = mlb2011.Final,
                Open = mlb2011.Open,
                Close = mlb2011.Close,
                OpenOU = mlb2011.OpenOU,
                column20 = mlb2011.column20,
                CloseOU = mlb2011.CloseOU,
                column22 = mlb2011.column22,
            };
            return mlb2011ViewModel;
        }

        public async Task UpdateAsync(Mlb2011ViewModel mlb2011Ubdate)
        {
            var mlb2011 = await _dbContext.Mlbs2011.FindAsync(mlb2011Ubdate.Id);
            mlb2011.Date = mlb2011Ubdate.Date;
            mlb2011.Rot = mlb2011Ubdate.Rot;
            mlb2011.VH = mlb2011Ubdate.VH;
            mlb2011.Team = mlb2011Ubdate.Team;
            mlb2011.Pitcher = mlb2011Ubdate.Pitcher;
            mlb2011._1st = mlb2011Ubdate._1st;
            mlb2011._2nd = mlb2011Ubdate._2nd;
            mlb2011._3rd = mlb2011Ubdate._3rd;
            mlb2011._4th = mlb2011Ubdate._4th;
            mlb2011._5th = mlb2011Ubdate._5th;
            mlb2011._6th = mlb2011Ubdate._6th;
            mlb2011._7th = mlb2011Ubdate._7th;
            mlb2011._8th = mlb2011Ubdate._8th;
            mlb2011._9th = mlb2011Ubdate._9th;
            mlb2011.Final = mlb2011Ubdate.Final;
            mlb2011.Open = mlb2011Ubdate.Open;
            mlb2011.Close = mlb2011Ubdate.Close;
            mlb2011.OpenOU = mlb2011Ubdate.OpenOU;
            mlb2011.column20 = mlb2011Ubdate.column20;
            mlb2011.CloseOU = mlb2011Ubdate.CloseOU;
            mlb2011.column22 = mlb2011Ubdate.column22;
            _dbContext.Mlbs2011.Update(mlb2011);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2011ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2011
                .Select(e => new Mlb2011ViewModel
                {
                    Id = e.Id,
                    Date = e.Date,
                    Rot = e.Rot,
                    VH = e.VH,
                    Team = e.Team,
                    Pitcher = e.Pitcher,
                    _1st = e._1st,
                    _2nd = e._2nd,
                    _3rd = e._3rd,
                    _4th = e._4th,
                    _5th = e._5th,
                    _6th = e._6th,
                    _7th = e._7th,
                    _8th = e._8th,
                    _9th = e._9th,
                    Final = e.Final,
                    Open = e.Open,
                    Close = e.Close,
                    OpenOU = e.OpenOU,
                    column20 = e.column20,
                    CloseOU = e.CloseOU,
                    column22 = e.column22,
                }).ToListAsync();
        }
    }
}
