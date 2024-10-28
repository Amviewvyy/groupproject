using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2018Repository : IMlb2018Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2018Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2018ViewModel mlb2018)
        {
            var newMlb2018 = new Mlb2018()
            {
                Date = mlb2018.Date,
                Rot = mlb2018.Rot,
                VH = mlb2018.VH,
                Team = mlb2018.Team,
                Pitcher = mlb2018.Pitcher,
                _1st = mlb2018._1st,
                _2nd = mlb2018._2nd,
                _3rd = mlb2018._3rd,
                _4th = mlb2018._4th,
                _5th = mlb2018._5th,
                _6th = mlb2018._6th,
                _7th = mlb2018._7th,
                _8th = mlb2018._8th,
                _9th = mlb2018._9th,
                Final = mlb2018.Final,
                Open = mlb2018.Open,
                Close = mlb2018.Close,
                Run_line = mlb2018.Run_line,
                column20 = mlb2018.column20,
                OpenOU = mlb2018.OpenOU,
                column22 = mlb2018.column22,
                CloseOU = mlb2018.CloseOU,
                column24 = mlb2018.column24,
            };
            await _dbContext.Mlbs2018.AddAsync(newMlb2018);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2018 mlb2018 = await _dbContext.Mlbs2018.FindAsync(Id);
            if (mlb2018 != null)
            {
                _dbContext.Mlbs2018.Remove(mlb2018);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2018ViewModel> GetAllAsync()
        {
            var mlbs2018 = _dbContext.Mlbs2018
            .Select(e => new Mlb2018ViewModel
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

            return mlbs2018;
        }

        public async Task<Mlb2018ViewModel> GetByIdAsync(int id)
        {
            var mlb2018 = await _dbContext.Mlbs2018.FindAsync(id);
            var mlb2018ViewModel = new Mlb2018ViewModel
            {
                Id = mlb2018.Id,
                Date = mlb2018.Date,
                Rot = mlb2018.Rot,
                VH = mlb2018.VH,
                Team = mlb2018.Team,
                Pitcher = mlb2018.Pitcher,
                _1st = mlb2018._1st,
                _2nd = mlb2018._2nd,
                _3rd = mlb2018._3rd,
                _4th = mlb2018._4th,
                _5th = mlb2018._5th,
                _6th = mlb2018._6th,
                _7th = mlb2018._7th,
                _8th = mlb2018._8th,
                _9th = mlb2018._9th,
                Final = mlb2018.Final,
                Open = mlb2018.Open,
                Close = mlb2018.Close,
                Run_line = mlb2018.Run_line,
                column20 = mlb2018.column20,
                OpenOU = mlb2018.OpenOU,
                column22 = mlb2018.column22,
                CloseOU = mlb2018.CloseOU,
                column24 = mlb2018.column24,
            };
            return mlb2018ViewModel;
        }

        public async Task UpdateAsync(Mlb2018ViewModel mlb2018Ubdate)
        {
            var mlb2018 = await _dbContext.Mlbs2018.FindAsync(mlb2018Ubdate.Id);
            mlb2018.Date = mlb2018Ubdate.Date;
            mlb2018.Rot = mlb2018Ubdate.Rot;
            mlb2018.VH = mlb2018Ubdate.VH;
            mlb2018.Team = mlb2018Ubdate.Team;
            mlb2018.Pitcher = mlb2018Ubdate.Pitcher;
            mlb2018._1st = mlb2018Ubdate._1st;
            mlb2018._2nd = mlb2018Ubdate._2nd;
            mlb2018._3rd = mlb2018Ubdate._3rd;
            mlb2018._4th = mlb2018Ubdate._4th;
            mlb2018._5th = mlb2018Ubdate._5th;
            mlb2018._6th = mlb2018Ubdate._6th;
            mlb2018._7th = mlb2018Ubdate._7th;
            mlb2018._8th = mlb2018Ubdate._8th;
            mlb2018._9th = mlb2018Ubdate._9th;
            mlb2018.Final = mlb2018Ubdate.Final;
            mlb2018.Open = mlb2018Ubdate.Open;
            mlb2018.Close = mlb2018Ubdate.Close;
            mlb2018.Run_line = mlb2018Ubdate.Run_line;
            mlb2018.column20 = mlb2018Ubdate.column20;
            mlb2018.OpenOU = mlb2018Ubdate.OpenOU;
            mlb2018.column22 = mlb2018Ubdate.column22;
            mlb2018.CloseOU = mlb2018Ubdate.CloseOU;
            mlb2018.column24 = mlb2018Ubdate.column24;
            _dbContext.Mlbs2018.Update(mlb2018);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2018ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2018
                .Select(e => new Mlb2018ViewModel
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

