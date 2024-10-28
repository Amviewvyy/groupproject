using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.FileSystemGlobbing;
using ProjectDatabase.Data;
using ProjectDatabase.Models;
using ProjectDatabase.ViewModels;
using System.Drawing;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectDatabase.Repositories
{
    public class Mlb2010Repository : IMlb2010Repository
    {
        private readonly AppDbContext _dbContext;
        public Mlb2010Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Mlb2010ViewModel mlb2010)
        {
            var newMlb2010 = new Mlb2010()
            {
                Date = mlb2010.Date,
                Rot = mlb2010.Rot,
                VH = mlb2010.VH,
                Team = mlb2010.Team,
                Pitcher = mlb2010.Pitcher,
                _1st = mlb2010._1st,
                _2nd = mlb2010._2nd,
                _3rd = mlb2010._3rd,
                _4th = mlb2010._4th,
                _5th = mlb2010._5th,
                _6th = mlb2010._6th,
                _7th = mlb2010._7th,
                _8th = mlb2010._8th,
                _9th = mlb2010._9th,
                Final = mlb2010.Final,
                Open = mlb2010.Open,
                Close = mlb2010.Close,
                OpenOU = mlb2010.OpenOU,
                column20 = mlb2010.column20,
                CloseOU = mlb2010.CloseOU,
                column22 = mlb2010.column22,
            };
            await _dbContext.Mlbs2010.AddAsync(newMlb2010);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            Mlb2010 mlb2010 = await _dbContext.Mlbs2010.FindAsync(Id);
            if (mlb2010 != null)
            {
                _dbContext.Mlbs2010.Remove(mlb2010);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IQueryable<Mlb2010ViewModel> GetAllAsync()
        {
            var mlbs2010 = _dbContext.Mlbs2010
            .Select(e => new Mlb2010ViewModel
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

            return mlbs2010;
        }

        public async Task<Mlb2010ViewModel> GetByIdAsync(int id)
        {
            var mlb2010 = await _dbContext.Mlbs2010.FindAsync(id);
            var mlb2010ViewModel = new Mlb2010ViewModel
            {
                Id = mlb2010.Id,
                Date = mlb2010.Date,
                Rot = mlb2010.Rot,
                VH = mlb2010.VH,
                Team = mlb2010.Team,
                Pitcher = mlb2010.Pitcher,
                _1st = mlb2010._1st,
                _2nd = mlb2010._2nd,
                _3rd = mlb2010._3rd,
                _4th = mlb2010._4th,
                _5th = mlb2010._5th,
                _6th = mlb2010._6th,
                _7th = mlb2010._7th,
                _8th = mlb2010._8th,
                _9th = mlb2010._9th,
                Final = mlb2010.Final,
                Open = mlb2010.Open,
                Close = mlb2010.Close,
                OpenOU = mlb2010.OpenOU,
                column20 = mlb2010.column20,
                CloseOU = mlb2010.CloseOU,
                column22 = mlb2010.column22,
            };
            return mlb2010ViewModel;
        }

        public async Task UpdateAsync(Mlb2010ViewModel mlb2010Ubdate)
        {
            var mlb2010 = await _dbContext.Mlbs2010.FindAsync(mlb2010Ubdate.Id);
            mlb2010.Date = mlb2010Ubdate.Date;
            mlb2010.Rot = mlb2010Ubdate.Rot;
            mlb2010.VH = mlb2010Ubdate.VH;
            mlb2010.Team = mlb2010Ubdate.Team;
            mlb2010.Pitcher = mlb2010Ubdate.Pitcher;
            mlb2010._1st = mlb2010Ubdate._1st;
            mlb2010._2nd = mlb2010Ubdate._2nd;
            mlb2010._3rd = mlb2010Ubdate._3rd;
            mlb2010._4th = mlb2010Ubdate._4th;
            mlb2010._5th = mlb2010Ubdate._5th;
            mlb2010._6th = mlb2010Ubdate._6th;
            mlb2010._7th = mlb2010Ubdate._7th;
            mlb2010._8th = mlb2010Ubdate._8th;
            mlb2010._9th = mlb2010Ubdate._9th;
            mlb2010.Final = mlb2010Ubdate.Final;
            mlb2010.Open = mlb2010Ubdate.Open;
            mlb2010.Close = mlb2010Ubdate.Close;
            mlb2010.OpenOU = mlb2010Ubdate.OpenOU;
            mlb2010.column20 = mlb2010Ubdate.column20;
            mlb2010.CloseOU = mlb2010Ubdate.CloseOU;
            mlb2010.column22 = mlb2010Ubdate.column22;
            _dbContext.Mlbs2010.Update(mlb2010);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Mlb2010ViewModel>> GetAllAsListAsync()
        {
            return await _dbContext.Mlbs2010
                .Select(e => new Mlb2010ViewModel
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