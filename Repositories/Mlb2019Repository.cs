using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2019Repository : IMlb2019Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2019Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2019ViewModel mlb2019)
        {
            var newMlb2019 = new Mlb2019()
            {
                Date = mlb2019.Date,
                Rot = mlb2019.Rot,
                VH = mlb2019.VH,
                Team = mlb2019.Team,
                Pitcher = mlb2019.Pitcher,
                _1st = mlb2019._1st,
                _2nd = mlb2019._2nd,
                _3rd = mlb2019._3rd,
                _4th = mlb2019._4th,
                _5th = mlb2019._5th,
                _6th = mlb2019._6th,
                _7th = mlb2019._7th,
                _8th = mlb2019._8th,
                _9th = mlb2019._9th,
                Final = mlb2019.Final,
                Open = mlb2019.Open,
                Close = mlb2019.Close,
                Run_line = mlb2019.Run_line,
                column20 = mlb2019.column20,
                OpenOU = mlb2019.OpenOU,
                column22 = mlb2019.column22,
                CloseOU = mlb2019.CloseOU,
                column24 = mlb2019.column24,
            };
            await _dbContext.Mlbs2019.AddAsync(newMlb2019);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2019 mlb2019 = await _dbContext.Mlbs2019.FindAsync(Id);
            if (mlb2019 != null)
            {
                _dbContext.Mlbs2019.Remove(mlb2019);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2019ViewModel> GetAllAsync()
        {
            var mlbs2019 = _dbContext.Mlbs2019
            .Select(e => new Mlb2019ViewModel
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

            return mlbs2019;
        }

        public async Task<Mlb2019ViewModel> GetByIdAsync(int id)
        {
            var mlb2019 = await _dbContext.Mlbs2019.FindAsync(id);
            var mlb2019ViewModel = new Mlb2019ViewModel
            {
                Id = mlb2019.Id,
                Date = mlb2019.Date,
                Rot = mlb2019.Rot,
                VH = mlb2019.VH,
                Team = mlb2019.Team,
                Pitcher = mlb2019.Pitcher,
                _1st = mlb2019._1st,
                _2nd = mlb2019._2nd,
                _3rd = mlb2019._3rd,
                _4th = mlb2019._4th,
                _5th = mlb2019._5th,
                _6th = mlb2019._6th,
                _7th = mlb2019._7th,
                _8th = mlb2019._8th,
                _9th = mlb2019._9th,
                Final = mlb2019.Final,
                Open = mlb2019.Open,
                Close = mlb2019.Close,
                Run_line = mlb2019.Run_line,
                column20 = mlb2019.column20,
                OpenOU = mlb2019.OpenOU,
                column22 = mlb2019.column22,
                CloseOU = mlb2019.CloseOU,
                column24 = mlb2019.column24,
            };
            return mlb2019ViewModel;
        }

        public async Task UpdateAsync(Mlb2019ViewModel mlb2019Ubdate)
        {
            var mlb2019 = await _dbContext.Mlbs2019.FindAsync(mlb2019Ubdate.Id);
            mlb2019.Date = mlb2019Ubdate.Date;
            mlb2019.Rot = mlb2019Ubdate.Rot;
            mlb2019.VH = mlb2019Ubdate.VH;
            mlb2019.Team = mlb2019Ubdate.Team;
            mlb2019.Pitcher = mlb2019Ubdate.Pitcher;
            mlb2019._1st = mlb2019Ubdate._1st;
            mlb2019._2nd = mlb2019Ubdate._2nd;
            mlb2019._3rd = mlb2019Ubdate._3rd;
            mlb2019._4th = mlb2019Ubdate._4th;
            mlb2019._5th = mlb2019Ubdate._5th;
            mlb2019._6th = mlb2019Ubdate._6th;
            mlb2019._7th = mlb2019Ubdate._7th;
            mlb2019._8th = mlb2019Ubdate._8th;
            mlb2019._9th = mlb2019Ubdate._9th;
            mlb2019.Final = mlb2019Ubdate.Final;
            mlb2019.Open = mlb2019Ubdate.Open;
            mlb2019.Close = mlb2019Ubdate.Close;
            mlb2019.Run_line = mlb2019Ubdate.Run_line;
            mlb2019.column20 = mlb2019Ubdate.column20;
            mlb2019.OpenOU = mlb2019Ubdate.OpenOU;
            mlb2019.column22 = mlb2019Ubdate.column22;
            mlb2019.CloseOU = mlb2019Ubdate.CloseOU;
            mlb2019.column24 = mlb2019Ubdate.column24;
            _dbContext.Mlbs2019.Update(mlb2019);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2019ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2019
                .Select(e => new Mlb2019ViewModel
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

