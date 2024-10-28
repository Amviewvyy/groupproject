using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2017Repository : IMlb2017Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2017Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2017ViewModel mlb2017)
        {
            var newMlb2017 = new Mlb2017()
            {
                Date = mlb2017.Date,
                Rot = mlb2017.Rot,
                VH = mlb2017.VH,
                Team = mlb2017.Team,
                Pitcher = mlb2017.Pitcher,
                _1st = mlb2017._1st,
                _2nd = mlb2017._2nd,
                _3rd = mlb2017._3rd,
                _4th = mlb2017._4th,
                _5th = mlb2017._5th,
                _6th = mlb2017._6th,
                _7th = mlb2017._7th,
                _8th = mlb2017._8th,
                _9th = mlb2017._9th,
                Final = mlb2017.Final,
                Open = mlb2017.Open,
                Close = mlb2017.Close,
                Run_line = mlb2017.Run_line,
                column20 = mlb2017.column20,
                OpenOU = mlb2017.OpenOU,
                column22 = mlb2017.column22,
                CloseOU = mlb2017.CloseOU,
                column24 = mlb2017.column24,
            };
            await _dbContext.Mlbs2017.AddAsync(newMlb2017);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2017 mlb2017 = await _dbContext.Mlbs2017.FindAsync(Id);
            if (mlb2017 != null)
            {
                _dbContext.Mlbs2017.Remove(mlb2017);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2017ViewModel> GetAllAsync()
        {
            var mlbs2017 = _dbContext.Mlbs2017
            .Select(e => new Mlb2017ViewModel
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

            return mlbs2017;
        }

        public async Task<Mlb2017ViewModel> GetByIdAsync(int id)
        {
            var mlb2017 = await _dbContext.Mlbs2017.FindAsync(id);
            var mlb2017ViewModel = new Mlb2017ViewModel
            {
                Id = mlb2017.Id,
                Date = mlb2017.Date,
                Rot = mlb2017.Rot,
                VH = mlb2017.VH,
                Team = mlb2017.Team,
                Pitcher = mlb2017.Pitcher,
                _1st = mlb2017._1st,
                _2nd = mlb2017._2nd,
                _3rd = mlb2017._3rd,
                _4th = mlb2017._4th,
                _5th = mlb2017._5th,
                _6th = mlb2017._6th,
                _7th = mlb2017._7th,
                _8th = mlb2017._8th,
                _9th = mlb2017._9th,
                Final = mlb2017.Final,
                Open = mlb2017.Open,
                Close = mlb2017.Close,
                Run_line = mlb2017.Run_line,
                column20 = mlb2017.column20,
                OpenOU = mlb2017.OpenOU,
                column22 = mlb2017.column22,
                CloseOU = mlb2017.CloseOU,
                column24 = mlb2017.column24,
            };
            return mlb2017ViewModel;
        }

        public async Task UpdateAsync(Mlb2017ViewModel mlb2017Ubdate)
        {
            var mlb2017 = await _dbContext.Mlbs2017.FindAsync(mlb2017Ubdate.Id);
            mlb2017.Date = mlb2017Ubdate.Date;
            mlb2017.Rot = mlb2017Ubdate.Rot;
            mlb2017.VH = mlb2017Ubdate.VH;
            mlb2017.Team = mlb2017Ubdate.Team;
            mlb2017.Pitcher = mlb2017Ubdate.Pitcher;
            mlb2017._1st = mlb2017Ubdate._1st;
            mlb2017._2nd = mlb2017Ubdate._2nd;
            mlb2017._3rd = mlb2017Ubdate._3rd;
            mlb2017._4th = mlb2017Ubdate._4th;
            mlb2017._5th = mlb2017Ubdate._5th;
            mlb2017._6th = mlb2017Ubdate._6th;
            mlb2017._7th = mlb2017Ubdate._7th;
            mlb2017._8th = mlb2017Ubdate._8th;
            mlb2017._9th = mlb2017Ubdate._9th;
            mlb2017.Final = mlb2017Ubdate.Final;
            mlb2017.Open = mlb2017Ubdate.Open;
            mlb2017.Close = mlb2017Ubdate.Close;
            mlb2017.Run_line = mlb2017Ubdate.Run_line;
            mlb2017.column20 = mlb2017Ubdate.column20;
            mlb2017.OpenOU = mlb2017Ubdate.OpenOU;
            mlb2017.column22 = mlb2017Ubdate.column22;
            mlb2017.CloseOU = mlb2017Ubdate.CloseOU;
            mlb2017.column24 = mlb2017Ubdate.column24;
            _dbContext.Mlbs2017.Update(mlb2017);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2017ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2017
                .Select(e => new Mlb2017ViewModel
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

