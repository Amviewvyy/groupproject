using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Models;

namespace ProjectDatabase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //DbSet properties
        public DbSet<Mlb2010> Mlbs2010 { get; set; }
        public DbSet<Mlb2011> Mlbs2011 { get; set; }
        public DbSet<Mlb2012> Mlbs2012 { get; set; }
        public DbSet<Mlb2013> Mlbs2013 { get; set; }
        public DbSet<Mlb2014> Mlbs2014 { get; set; }
        public DbSet<Mlb2015> Mlbs2015 { get; set; }
        public DbSet<Mlb2016> Mlbs2016 { get; set; }
        public DbSet<Mlb2017> Mlbs2017 { get; set; }
        public DbSet<Mlb2018> Mlbs2018 { get; set; }
        public DbSet<Mlb2019> Mlbs2019 { get; set; }
        public DbSet<Mlb2020> Mlbs2020 { get; set; }
        public DbSet<Mlb2021> Mlbs2021 { get; set; }

    }
}
