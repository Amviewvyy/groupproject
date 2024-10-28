using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2021Repository : IMlb2021Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2021Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2021ViewModel mlb2021)
        {
            var newMlb2021 = new Mlb2021()
            {
                Date = mlb2021.Date,
                Rot = mlb2021.Rot,
                VH = mlb2021.VH,
                Team = mlb2021.Team,
                Pitcher = mlb2021.Pitcher,
                _1st = mlb2021._1st,
                _2nd = mlb2021._2nd,
                _3rd = mlb2021._3rd,
                _4th = mlb2021._4th,
                _5th = mlb2021._5th,
                _6th = mlb2021._6th,
                _7th = mlb2021._7th,
                _8th = mlb2021._8th,
                _9th = mlb2021._9th,
                Final = mlb2021.Final,
                Open = mlb2021.Open,
                Close = mlb2021.Close,
                Run_line = mlb2021.Run_line,
                column20 = mlb2021.column20,
                OpenOU = mlb2021.OpenOU,
                column22 = mlb2021.column22,
                CloseOU = mlb2021.CloseOU,
                column24 = mlb2021.column24,
            };
            await _dbContext.Mlbs2021.AddAsync(newMlb2021);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2021 mlb2021 = await _dbContext.Mlbs2021.FindAsync(Id);
            if (mlb2021 != null)
            {
                _dbContext.Mlbs2021.Remove(mlb2021);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2021ViewModel> GetAllAsync()
        {
            var mlbs2021 = _dbContext.Mlbs2021
            .Select(e => new Mlb2021ViewModel
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

            return mlbs2021;
        }

        public async Task<Mlb2021ViewModel> GetByIdAsync(int id)
        {
            var mlb2021 = await _dbContext.Mlbs2021.FindAsync(id);
            var mlb2021ViewModel = new Mlb2021ViewModel
            {
                Id = mlb2021.Id,
                Date = mlb2021.Date,
                Rot = mlb2021.Rot,
                VH = mlb2021.VH,
                Team = mlb2021.Team,
                Pitcher = mlb2021.Pitcher,
                _1st = mlb2021._1st,
                _2nd = mlb2021._2nd,
                _3rd = mlb2021._3rd,
                _4th = mlb2021._4th,
                _5th = mlb2021._5th,
                _6th = mlb2021._6th,
                _7th = mlb2021._7th,
                _8th = mlb2021._8th,
                _9th = mlb2021._9th,
                Final = mlb2021.Final,
                Open = mlb2021.Open,
                Close = mlb2021.Close,
                Run_line = mlb2021.Run_line,
                column20 = mlb2021.column20,
                OpenOU = mlb2021.OpenOU,
                column22 = mlb2021.column22,
                CloseOU = mlb2021.CloseOU,
                column24 = mlb2021.column24,
            };
            return mlb2021ViewModel;
        }

        public async Task UpdateAsync(Mlb2021ViewModel mlb2021Ubdate)
        {
            var mlb2021 = await _dbContext.Mlbs2021.FindAsync(mlb2021Ubdate.Id);
            mlb2021.Date = mlb2021Ubdate.Date;
            mlb2021.Rot = mlb2021Ubdate.Rot;
            mlb2021.VH = mlb2021Ubdate.VH;
            mlb2021.Team = mlb2021Ubdate.Team;
            mlb2021.Pitcher = mlb2021Ubdate.Pitcher;
            mlb2021._1st = mlb2021Ubdate._1st;
            mlb2021._2nd = mlb2021Ubdate._2nd;
            mlb2021._3rd = mlb2021Ubdate._3rd;
            mlb2021._4th = mlb2021Ubdate._4th;
            mlb2021._5th = mlb2021Ubdate._5th;
            mlb2021._6th = mlb2021Ubdate._6th;
            mlb2021._7th = mlb2021Ubdate._7th;
            mlb2021._8th = mlb2021Ubdate._8th;
            mlb2021._9th = mlb2021Ubdate._9th;
            mlb2021.Final = mlb2021Ubdate.Final;
            mlb2021.Open = mlb2021Ubdate.Open;
            mlb2021.Close = mlb2021Ubdate.Close;
            mlb2021.Run_line = mlb2021Ubdate.Run_line;
            mlb2021.column20 = mlb2021Ubdate.column20;
            mlb2021.OpenOU = mlb2021Ubdate.OpenOU;
            mlb2021.column22 = mlb2021Ubdate.column22;
            mlb2021.CloseOU = mlb2021Ubdate.CloseOU;
            mlb2021.column24 = mlb2021Ubdate.column24;
            _dbContext.Mlbs2021.Update(mlb2021);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2021ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2021
                .Select(e => new Mlb2021ViewModel
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

