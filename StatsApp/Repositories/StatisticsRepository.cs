using Microsoft.EntityFrameworkCore;
using StatsApp.Data;
using StatsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StatsApp.Repositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly AppDbContext _context;

        public StatisticsRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Statistics> FindAllByDate(DateTime from, DateTime to)
        {
            List<Statistics> stats = _context.Statistics
                .Where(s => s.Date.Date >= from.Date && s.Date.Date <= to.Date)
                .OrderBy(s => s.Date)
                .ToList();
            return stats;
        }

        public void CreateStatistics(Statistics statistics)
        {
            _context.Statistics.Add(statistics);
            _context.SaveChanges();
        }

        public void DeleteAll()
        {
            _context.Database.ExecuteSqlRaw("TRUNCATE TABLE Statistics");
        }
    }
}
