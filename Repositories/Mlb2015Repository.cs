using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2015Repository : IMlb2015Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2015Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2015ViewModel mlb2015)
        {
            var newMlb2015 = new Mlb2015()
            {
                Date = mlb2015.Date,
                Rot = mlb2015.Rot,
                VH = mlb2015.VH,
                Team = mlb2015.Team,
                Pitcher = mlb2015.Pitcher,
                _1st = mlb2015._1st,
                _2nd = mlb2015._2nd,
                _3rd = mlb2015._3rd,
                _4th = mlb2015._4th,
                _5th = mlb2015._5th,
                _6th = mlb2015._6th,
                _7th = mlb2015._7th,
                _8th = mlb2015._8th,
                _9th = mlb2015._9th,
                Final = mlb2015.Final,
                Open = mlb2015.Open,
                Close = mlb2015.Close,
                Run_line = mlb2015.Run_line,
                column20 = mlb2015.column20,
                OpenOU = mlb2015.OpenOU,
                column22 = mlb2015.column22,
                CloseOU = mlb2015.CloseOU,
                column24 = mlb2015.column24,
            };
            await _dbContext.Mlbs2015.AddAsync(newMlb2015);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2015 mlb2015 = await _dbContext.Mlbs2015.FindAsync(Id);
            if (mlb2015 != null)
            {
                _dbContext.Mlbs2015.Remove(mlb2015);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2015ViewModel> GetAllAsync()
        {
            var mlbs2015 = _dbContext.Mlbs2015
            .Select(e => new Mlb2015ViewModel
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
                Run_line = e.Run_line,
                column20 = e.column20,
                OpenOU = e.OpenOU,
                column22 = e.column22,
                CloseOU = e.CloseOU,
                column24 = e.column24,
            });

            return mlbs2015;
        }

        public async Task<Mlb2015ViewModel> GetByIdAsync(int id)
        {
            var mlb2015 = await _dbContext.Mlbs2015.FindAsync(id);
            var mlb2015ViewModel = new Mlb2015ViewModel
            {
                Id = mlb2015.Id,
                Date = mlb2015.Date,
                Rot = mlb2015.Rot,
                VH = mlb2015.VH,
                Team = mlb2015.Team,
                Pitcher = mlb2015.Pitcher,
                _1st = mlb2015._1st,
                _2nd = mlb2015._2nd,
                _3rd = mlb2015._3rd,
                _4th = mlb2015._4th,
                _5th = mlb2015._5th,
                _6th = mlb2015._6th,
                _7th = mlb2015._7th,
                _8th = mlb2015._8th,
                _9th = mlb2015._9th,
                Final = mlb2015.Final,
                Open = mlb2015.Open,
                Close = mlb2015.Close,
                Run_line = mlb2015.Run_line,
                column20 = mlb2015.column20,
                OpenOU = mlb2015.OpenOU,
                column22 = mlb2015.column22,
                CloseOU = mlb2015.CloseOU,
                column24 = mlb2015.column24,
            };
            return mlb2015ViewModel;
        }

        public async Task UpdateAsync(Mlb2015ViewModel mlb2015Ubdate)
        {
            var mlb2015 = await _dbContext.Mlbs2015.FindAsync(mlb2015Ubdate.Id);
            mlb2015.Date = mlb2015Ubdate.Date;
            mlb2015.Rot = mlb2015Ubdate.Rot;
            mlb2015.VH = mlb2015Ubdate.VH;
            mlb2015.Team = mlb2015Ubdate.Team;
            mlb2015.Pitcher = mlb2015Ubdate.Pitcher;
            mlb2015._1st = mlb2015Ubdate._1st;
            mlb2015._2nd = mlb2015Ubdate._2nd;
            mlb2015._3rd = mlb2015Ubdate._3rd;
            mlb2015._4th = mlb2015Ubdate._4th;
            mlb2015._5th = mlb2015Ubdate._5th;
            mlb2015._6th = mlb2015Ubdate._6th;
            mlb2015._7th = mlb2015Ubdate._7th;
            mlb2015._8th = mlb2015Ubdate._8th;
            mlb2015._9th = mlb2015Ubdate._9th;
            mlb2015.Final = mlb2015Ubdate.Final;
            mlb2015.Open = mlb2015Ubdate.Open;
            mlb2015.Close = mlb2015Ubdate.Close;
            mlb2015.Run_line = mlb2015Ubdate.Run_line;
            mlb2015.column20 = mlb2015Ubdate.column20;
            mlb2015.OpenOU = mlb2015Ubdate.OpenOU;
            mlb2015.column22 = mlb2015Ubdate.column22;
            mlb2015.CloseOU = mlb2015Ubdate.CloseOU;
            mlb2015.column24 = mlb2015Ubdate.column24;
            _dbContext.Mlbs2015.Update(mlb2015);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2015ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2015
                .Select(e => new Mlb2015ViewModel
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
                    Run_line = e.Run_line,
                    column20 = e.column20,
                    OpenOU = e.OpenOU,
                    column22 = e.column22,
                    CloseOU = e.CloseOU,
                    column24 = e.column24,
                }).ToListAsync();
        }
    }
}

