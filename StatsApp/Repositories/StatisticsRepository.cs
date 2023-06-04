using Microsoft.EntityFrameworkCore;
using StatsApp.Data;
using StatsApp.Data.Dtos;
using StatsApp.Data.Mapper;
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

        public IEnumerable<StatsResponseDto> GetAllByDate(DateTime from, DateTime to)
        {
            List<Statistics> stats = _context.Statistics
                .Where(s => s.Date.Date >= from.Date && s.Date.Date <= to.Date)
                .OrderBy(s => s.Date)
                .ToList();
            List<StatsResponseDto> result = new List<StatsResponseDto>();
            foreach(Statistics s in stats)
            {
                result.Add(StatsMapper.ModelToResponse(s));
            }
            return result;
        }


        //test method
        public Statistics GetByDate(DateTime requestDate)
        {
            DateTime date = requestDate.Date;
            return _context.Statistics.FirstOrDefault(x => x.Date == date);
        }

        //done
        public void Create(StatsRequestDto stat)
        {
            Statistics statistics = StatsMapper.ReqToModel(stat);
            _context.Statistics.Add(statistics);
            _context.SaveChanges();
        }

        //should it be implemented?
        public void Update(StatsRequestDto stat)
        {
            throw new NotImplementedException();
        }

        //done
        public void DeleteAll()
        {
            _context.Database.ExecuteSqlRaw("TRUNCATE TABLE Statistics");
        }

       
    }
}
