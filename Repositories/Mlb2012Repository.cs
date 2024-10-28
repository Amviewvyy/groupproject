using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ProjectDatabase.Repositories
{
    public class Mlb2012Repository : IMlb2012Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2012Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2012ViewModel mlb2012)
        {
            var newMlb2012 = new Mlb2012()
            {
                Date = mlb2012.Date,
                Rot = mlb2012.Rot,
                VH = mlb2012.VH,
                Team = mlb2012.Team,
                Pitcher = mlb2012.Pitcher,
                _1st = mlb2012._1st,
                _2nd = mlb2012._2nd,
                _3rd = mlb2012._3rd,
                _4th = mlb2012._4th,
                _5th = mlb2012._5th,
                _6th = mlb2012._6th,
                _7th = mlb2012._7th,
                _8th = mlb2012._8th,
                _9th = mlb2012._9th,
                Final = mlb2012.Final,
                Open = mlb2012.Open,
                Close = mlb2012.Close,
                OpenOU = mlb2012.OpenOU,
                column20 = mlb2012.column20,
                CloseOU = mlb2012.CloseOU,
                column22 = mlb2012.column22,
            };
            await _dbContext.Mlbs2012.AddAsync(newMlb2012);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2012 mlb2012 = await _dbContext.Mlbs2012.FindAsync(Id);
            if (mlb2012 != null)
            {
                _dbContext.Mlbs2012.Remove(mlb2012);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2012ViewModel> GetAllAsync()
        {
            var mlbs2012 = _dbContext.Mlbs2012
            .Select(e => new Mlb2012ViewModel
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

            return mlbs2012;
        }

        public async Task<Mlb2012ViewModel> GetByIdAsync(int id)
        {
            var mlb2012 = await _dbContext.Mlbs2012.FindAsync(id);
            var mlb2012ViewModel = new Mlb2012ViewModel
            {
                Id = mlb2012.Id,
                Date = mlb2012.Date,
                Rot = mlb2012.Rot,
                VH = mlb2012.VH,
                Team = mlb2012.Team,
                Pitcher = mlb2012.Pitcher,
                _1st = mlb2012._1st,
                _2nd = mlb2012._2nd,
                _3rd = mlb2012._3rd,
                _4th = mlb2012._4th,
                _5th = mlb2012._5th,
                _6th = mlb2012._6th,
                _7th = mlb2012._7th,
                _8th = mlb2012._8th,
                _9th = mlb2012._9th,
                Final = mlb2012.Final,
                Open = mlb2012.Open,
                Close = mlb2012.Close,
                OpenOU = mlb2012.OpenOU,
                column20 = mlb2012.column20,
                CloseOU = mlb2012.CloseOU,
                column22 = mlb2012.column22,
            };
            return mlb2012ViewModel;
        }

        public async Task UpdateAsync(Mlb2012ViewModel mlb2012Ubdate)
        {
            var mlb2012 = await _dbContext.Mlbs2012.FindAsync(mlb2012Ubdate.Id);
            mlb2012.Date = mlb2012Ubdate.Date;
            mlb2012.Rot = mlb2012Ubdate.Rot;
            mlb2012.VH = mlb2012Ubdate.VH;
            mlb2012.Team = mlb2012Ubdate.Team;
            mlb2012.Pitcher = mlb2012Ubdate.Pitcher;
            mlb2012._1st = mlb2012Ubdate._1st;
            mlb2012._2nd = mlb2012Ubdate._2nd;
            mlb2012._3rd = mlb2012Ubdate._3rd;
            mlb2012._4th = mlb2012Ubdate._4th;
            mlb2012._5th = mlb2012Ubdate._5th;
            mlb2012._6th = mlb2012Ubdate._6th;
            mlb2012._7th = mlb2012Ubdate._7th;
            mlb2012._8th = mlb2012Ubdate._8th;
            mlb2012._9th = mlb2012Ubdate._9th;
            mlb2012.Final = mlb2012Ubdate.Final;
            mlb2012.Open = mlb2012Ubdate.Open;
            mlb2012.Close = mlb2012Ubdate.Close;
            mlb2012.OpenOU = mlb2012Ubdate.OpenOU;
            mlb2012.column20 = mlb2012Ubdate.column20;
            mlb2012.CloseOU = mlb2012Ubdate.CloseOU;
            mlb2012.column22 = mlb2012Ubdate.column22;
            _dbContext.Mlbs2012.Update(mlb2012);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2012ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2012
                .Select(e => new Mlb2012ViewModel
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
