using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2020Repository : IMlb2020Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2020Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2020ViewModel mlb2020)
        {
            var newMlb2020 = new Mlb2020()
            {
                Date = mlb2020.Date,
                Rot = mlb2020.Rot,
                VH = mlb2020.VH,
                Team = mlb2020.Team,
                Pitcher = mlb2020.Pitcher,
                _1st = mlb2020._1st,
                _2nd = mlb2020._2nd,
                _3rd = mlb2020._3rd,
                _4th = mlb2020._4th,
                _5th = mlb2020._5th,
                _6th = mlb2020._6th,
                _7th = mlb2020._7th,
                _8th = mlb2020._8th,
                _9th = mlb2020._9th,
                Final = mlb2020.Final,
                Open = mlb2020.Open,
                Close = mlb2020.Close,
                Run_line = mlb2020.Run_line,
                column20 = mlb2020.column20,
                OpenOU = mlb2020.OpenOU,
                column22 = mlb2020.column22,
                CloseOU = mlb2020.CloseOU,
                column24 = mlb2020.column24,
            };
            await _dbContext.Mlbs2020.AddAsync(newMlb2020);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2020 mlb2020 = await _dbContext.Mlbs2020.FindAsync(Id);
            if (mlb2020 != null)
            {
                _dbContext.Mlbs2020.Remove(mlb2020);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2020ViewModel> GetAllAsync()
        {
            var mlbs2020 = _dbContext.Mlbs2020
            .Select(e => new Mlb2020ViewModel
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

            return mlbs2020;
        }

        public async Task<Mlb2020ViewModel> GetByIdAsync(int id)
        {
            var mlb2020 = await _dbContext.Mlbs2020.FindAsync(id);
            var mlb2020ViewModel = new Mlb2020ViewModel
            {
                Id = mlb2020.Id,
                Date = mlb2020.Date,
                Rot = mlb2020.Rot,
                VH = mlb2020.VH,
                Team = mlb2020.Team,
                Pitcher = mlb2020.Pitcher,
                _1st = mlb2020._1st,
                _2nd = mlb2020._2nd,
                _3rd = mlb2020._3rd,
                _4th = mlb2020._4th,
                _5th = mlb2020._5th,
                _6th = mlb2020._6th,
                _7th = mlb2020._7th,
                _8th = mlb2020._8th,
                _9th = mlb2020._9th,
                Final = mlb2020.Final,
                Open = mlb2020.Open,
                Close = mlb2020.Close,
                Run_line = mlb2020.Run_line,
                column20 = mlb2020.column20,
                OpenOU = mlb2020.OpenOU,
                column22 = mlb2020.column22,
                CloseOU = mlb2020.CloseOU,
                column24 = mlb2020.column24,
            };
            return mlb2020ViewModel;
        }

        public async Task UpdateAsync(Mlb2020ViewModel mlb2020Ubdate)
        {
            var mlb2020 = await _dbContext.Mlbs2020.FindAsync(mlb2020Ubdate.Id);
            mlb2020.Date = mlb2020Ubdate.Date;
            mlb2020.Rot = mlb2020Ubdate.Rot;
            mlb2020.VH = mlb2020Ubdate.VH;
            mlb2020.Team = mlb2020Ubdate.Team;
            mlb2020.Pitcher = mlb2020Ubdate.Pitcher;
            mlb2020._1st = mlb2020Ubdate._1st;
            mlb2020._2nd = mlb2020Ubdate._2nd;
            mlb2020._3rd = mlb2020Ubdate._3rd;
            mlb2020._4th = mlb2020Ubdate._4th;
            mlb2020._5th = mlb2020Ubdate._5th;
            mlb2020._6th = mlb2020Ubdate._6th;
            mlb2020._7th = mlb2020Ubdate._7th;
            mlb2020._8th = mlb2020Ubdate._8th;
            mlb2020._9th = mlb2020Ubdate._9th;
            mlb2020.Final = mlb2020Ubdate.Final;
            mlb2020.Open = mlb2020Ubdate.Open;
            mlb2020.Close = mlb2020Ubdate.Close;
            mlb2020.Run_line = mlb2020Ubdate.Run_line;
            mlb2020.column20 = mlb2020Ubdate.column20;
            mlb2020.OpenOU = mlb2020Ubdate.OpenOU;
            mlb2020.column22 = mlb2020Ubdate.column22;
            mlb2020.CloseOU = mlb2020Ubdate.CloseOU;
            mlb2020.column24 = mlb2020Ubdate.column24;
            _dbContext.Mlbs2020.Update(mlb2020);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2020ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2020
                .Select(e => new Mlb2020ViewModel
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

