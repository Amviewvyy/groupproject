using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2014Repository : IMlb2014Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2014Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2014ViewModel mlb2014)
        {
            var newMlb2014 = new Mlb2014()
            {
                Date = mlb2014.Date,
                Rot = mlb2014.Rot,
                VH = mlb2014.VH,
                Team = mlb2014.Team,
                Pitcher = mlb2014.Pitcher,
                _1st = mlb2014._1st,
                _2nd = mlb2014._2nd,
                _3rd = mlb2014._3rd,
                _4th = mlb2014._4th,
                _5th = mlb2014._5th,
                _6th = mlb2014._6th,
                _7th = mlb2014._7th,
                _8th = mlb2014._8th,
                _9th = mlb2014._9th,
                Final = mlb2014.Final,
                Open = mlb2014.Open,
                Close = mlb2014.Close,
                Run_line = mlb2014.Run_line,
                column20 = mlb2014.column20,
                OpenOU = mlb2014.OpenOU,
                column22 = mlb2014.column22,
                CloseOU = mlb2014.CloseOU,
                column24 = mlb2014.column24,
            };
            await _dbContext.Mlbs2014.AddAsync(newMlb2014);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2014 mlb2014 = await _dbContext.Mlbs2014.FindAsync(Id);
            if (mlb2014 != null)
            {
                _dbContext.Mlbs2014.Remove(mlb2014);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2014ViewModel> GetAllAsync()
        {
            var mlbs2014 = _dbContext.Mlbs2014
            .Select(e => new Mlb2014ViewModel
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

            return mlbs2014;
        }

        public async Task<Mlb2014ViewModel> GetByIdAsync(int id)
        {
            var mlb2014 = await _dbContext.Mlbs2014.FindAsync(id);
            var mlb2014ViewModel = new Mlb2014ViewModel
            {
                Id = mlb2014.Id,
                Date = mlb2014.Date,
                Rot = mlb2014.Rot,
                VH = mlb2014.VH,
                Team = mlb2014.Team,
                Pitcher = mlb2014.Pitcher,
                _1st = mlb2014._1st,
                _2nd = mlb2014._2nd,
                _3rd = mlb2014._3rd,
                _4th = mlb2014._4th,
                _5th = mlb2014._5th,
                _6th = mlb2014._6th,
                _7th = mlb2014._7th,
                _8th = mlb2014._8th,
                _9th = mlb2014._9th,
                Final = mlb2014.Final,
                Open = mlb2014.Open,
                Close = mlb2014.Close,
                Run_line = mlb2014.Run_line,
                column20 = mlb2014.column20,
                OpenOU = mlb2014.OpenOU,
                column22 = mlb2014.column22,
                CloseOU = mlb2014.CloseOU,
                column24 = mlb2014.column24,
            };
            return mlb2014ViewModel;
        }

        public async Task UpdateAsync(Mlb2014ViewModel mlb2014Ubdate)
        {
            var mlb2014 = await _dbContext.Mlbs2014.FindAsync(mlb2014Ubdate.Id);
            mlb2014.Date = mlb2014Ubdate.Date;
            mlb2014.Rot = mlb2014Ubdate.Rot;
            mlb2014.VH = mlb2014Ubdate.VH;
            mlb2014.Team = mlb2014Ubdate.Team;
            mlb2014.Pitcher = mlb2014Ubdate.Pitcher;
            mlb2014._1st = mlb2014Ubdate._1st;
            mlb2014._2nd = mlb2014Ubdate._2nd;
            mlb2014._3rd = mlb2014Ubdate._3rd;
            mlb2014._4th = mlb2014Ubdate._4th;
            mlb2014._5th = mlb2014Ubdate._5th;
            mlb2014._6th = mlb2014Ubdate._6th;
            mlb2014._7th = mlb2014Ubdate._7th;
            mlb2014._8th = mlb2014Ubdate._8th;
            mlb2014._9th = mlb2014Ubdate._9th;
            mlb2014.Final = mlb2014Ubdate.Final;
            mlb2014.Open = mlb2014Ubdate.Open;
            mlb2014.Close = mlb2014Ubdate.Close;
            mlb2014.Run_line = mlb2014Ubdate.Run_line;
            mlb2014.column20 = mlb2014Ubdate.column20;
            mlb2014.OpenOU = mlb2014Ubdate.OpenOU;
            mlb2014.column22 = mlb2014Ubdate.column22;
            mlb2014.CloseOU = mlb2014Ubdate.CloseOU;
            mlb2014.column24 = mlb2014Ubdate.column24;
            _dbContext.Mlbs2014.Update(mlb2014);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2014ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2014
                .Select(e => new Mlb2014ViewModel
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

