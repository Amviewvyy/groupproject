using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2013Repository : IMlb2013Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2013Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2013ViewModel mlb2013)
        {
            var newMlb2013 = new Mlb2013()
            {
                Date = mlb2013.Date,
                Rot = mlb2013.Rot,
                VH = mlb2013.VH,
                Team = mlb2013.Team,
                Pitcher = mlb2013.Pitcher,
                _1st = mlb2013._1st,
                _2nd = mlb2013._2nd,
                _3rd = mlb2013._3rd,
                _4th = mlb2013._4th,
                _5th = mlb2013._5th,
                _6th = mlb2013._6th,
                _7th = mlb2013._7th,
                _8th = mlb2013._8th,
                _9th = mlb2013._9th,
                Final = mlb2013.Final,
                Open = mlb2013.Open,
                Close = mlb2013.Close,
                OpenOU = mlb2013.OpenOU,
                column20 = mlb2013.column20,
                CloseOU = mlb2013.CloseOU,
                column22 = mlb2013.column22,
            };
            await _dbContext.Mlbs2013.AddAsync(newMlb2013);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2013 mlb2013 = await _dbContext.Mlbs2013.FindAsync(Id);
            if (mlb2013 != null)
            {
                _dbContext.Mlbs2013.Remove(mlb2013);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2013ViewModel> GetAllAsync()
        {
            var mlbs2013 = _dbContext.Mlbs2013
            .Select(e => new Mlb2013ViewModel
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

            return mlbs2013;
        }

        public async Task<Mlb2013ViewModel> GetByIdAsync(int id)
        {
            var mlb2013 = await _dbContext.Mlbs2013.FindAsync(id);
            var mlb2013ViewModel = new Mlb2013ViewModel
            {
                Id = mlb2013.Id,
                Date = mlb2013.Date,
                Rot = mlb2013.Rot,
                VH = mlb2013.VH,
                Team = mlb2013.Team,
                Pitcher = mlb2013.Pitcher,
                _1st = mlb2013._1st,
                _2nd = mlb2013._2nd,
                _3rd = mlb2013._3rd,
                _4th = mlb2013._4th,
                _5th = mlb2013._5th,
                _6th = mlb2013._6th,
                _7th = mlb2013._7th,
                _8th = mlb2013._8th,
                _9th = mlb2013._9th,
                Final = mlb2013.Final,
                Open = mlb2013.Open,
                Close = mlb2013.Close,
                OpenOU = mlb2013.OpenOU,
                column20 = mlb2013.column20,
                CloseOU = mlb2013.CloseOU,
                column22 = mlb2013.column22,
            };
            return mlb2013ViewModel;
        }

        public async Task UpdateAsync(Mlb2013ViewModel mlb2013Ubdate)
        {
            var mlb2013 = await _dbContext.Mlbs2013.FindAsync(mlb2013Ubdate.Id);
            mlb2013.Date = mlb2013Ubdate.Date;
            mlb2013.Rot = mlb2013Ubdate.Rot;
            mlb2013.VH = mlb2013Ubdate.VH;
            mlb2013.Team = mlb2013Ubdate.Team;
            mlb2013.Pitcher = mlb2013Ubdate.Pitcher;
            mlb2013._1st = mlb2013Ubdate._1st;
            mlb2013._2nd = mlb2013Ubdate._2nd;
            mlb2013._3rd = mlb2013Ubdate._3rd;
            mlb2013._4th = mlb2013Ubdate._4th;
            mlb2013._5th = mlb2013Ubdate._5th;
            mlb2013._6th = mlb2013Ubdate._6th;
            mlb2013._7th = mlb2013Ubdate._7th;
            mlb2013._8th = mlb2013Ubdate._8th;
            mlb2013._9th = mlb2013Ubdate._9th;
            mlb2013.Final = mlb2013Ubdate.Final;
            mlb2013.Open = mlb2013Ubdate.Open;
            mlb2013.Close = mlb2013Ubdate.Close;
            mlb2013.OpenOU = mlb2013Ubdate.OpenOU;
            mlb2013.column20 = mlb2013Ubdate.column20;
            mlb2013.CloseOU = mlb2013Ubdate.CloseOU;
            mlb2013.column22 = mlb2013Ubdate.column22;
            _dbContext.Mlbs2013.Update(mlb2013);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2013ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2013
                .Select(e => new Mlb2013ViewModel
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
