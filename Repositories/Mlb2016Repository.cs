using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;

namespace ProjectDatabase.Repositories
{
    public class Mlb2016Repository : IMlb2016Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2016Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2016ViewModel mlb2016)
        {
            var newMlb2016 = new Mlb2016()
            {
                Date = mlb2016.Date,
                Rot = mlb2016.Rot,
                VH =  mlb2016.VH,
                Team = mlb2016.Team,
                Pitcher = mlb2016.Pitcher,
                _1st = mlb2016._1st,
                _2nd = mlb2016._2nd,
                _3rd = mlb2016._3rd,
                _4th = mlb2016._4th,
                _5th = mlb2016._5th,
                _6th = mlb2016._6th,
                _7th = mlb2016._7th,
                _8th = mlb2016._8th,
                _9th = mlb2016._9th,
                Final = mlb2016.Final,
                Open = mlb2016.Open,
                Close = mlb2016.Close,
                Run_line = mlb2016.Run_line,
                column20 = mlb2016.column20,
                OpenOU = mlb2016.OpenOU,
                column22 = mlb2016.column22,
                CloseOU = mlb2016.CloseOU,
                column24 = mlb2016.column24,
            };
            await _dbContext.Mlbs2016.AddAsync(newMlb2016);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2016 mlb2016 = await _dbContext.Mlbs2016.FindAsync(Id);
            if (mlb2016 != null)
            {
                _dbContext.Mlbs2016.Remove(mlb2016);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2016ViewModel> GetAllAsync()
        {
            var mlbs2016 = _dbContext.Mlbs2016
            .Select(e => new Mlb2016ViewModel
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

            return mlbs2016;
        }

        public async Task<Mlb2016ViewModel> GetByIdAsync(int id)
        {
            var mlb2016 = await _dbContext.Mlbs2016.FindAsync(id);
            var mlb2016ViewModel = new Mlb2016ViewModel
            {
                Id = mlb2016.Id,
                Date = mlb2016.Date,
                Rot = mlb2016.Rot,
                VH = mlb2016.VH,
                Team = mlb2016.Team,
                Pitcher = mlb2016.Pitcher,
                _1st = mlb2016._1st,
                _2nd = mlb2016._2nd,
                _3rd = mlb2016._3rd,
                _4th = mlb2016._4th,
                _5th = mlb2016._5th,
                _6th = mlb2016._6th,
                _7th = mlb2016._7th,
                _8th = mlb2016._8th,
                _9th = mlb2016._9th,
                Final = mlb2016.Final,
                Open = mlb2016.Open,
                Close = mlb2016.Close,
                Run_line = mlb2016.Run_line,
                column20 = mlb2016.column20,
                OpenOU = mlb2016.OpenOU,
                column22 = mlb2016.column22,
                CloseOU = mlb2016.CloseOU,
                column24 = mlb2016.column24,
            };
            return mlb2016ViewModel;
        }

        public async Task UpdateAsync(Mlb2016ViewModel mlb2016Ubdate)
        {
            var mlb2016 = await _dbContext.Mlbs2016.FindAsync(mlb2016Ubdate.Id);
            mlb2016.Date = mlb2016Ubdate.Date;
            mlb2016.Rot = mlb2016Ubdate.Rot;
            mlb2016.VH = mlb2016Ubdate.VH;
            mlb2016.Team = mlb2016Ubdate.Team;
            mlb2016.Pitcher = mlb2016Ubdate.Pitcher;
            mlb2016._1st = mlb2016Ubdate._1st;
            mlb2016._2nd = mlb2016Ubdate._2nd;
            mlb2016._3rd = mlb2016Ubdate._3rd;
            mlb2016._4th = mlb2016Ubdate._4th;
            mlb2016._5th = mlb2016Ubdate._5th;
            mlb2016._6th = mlb2016Ubdate._6th;
            mlb2016._7th = mlb2016Ubdate._7th;
            mlb2016._8th = mlb2016Ubdate._8th;
            mlb2016._9th = mlb2016Ubdate._9th;
            mlb2016.Final = mlb2016Ubdate.Final;
            mlb2016.Open = mlb2016Ubdate.Open;
            mlb2016.Close = mlb2016Ubdate.Close;
            mlb2016.Run_line = mlb2016Ubdate.Run_line;
            mlb2016.column20 = mlb2016Ubdate.column20;
            mlb2016.OpenOU = mlb2016Ubdate.OpenOU;
            mlb2016.column22 = mlb2016Ubdate.column22;
            mlb2016.CloseOU = mlb2016Ubdate.CloseOU;
            mlb2016.column24 = mlb2016Ubdate.column24;
            _dbContext.Mlbs2016.Update(mlb2016);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2016ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2016
                .Select(e => new Mlb2016ViewModel
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
