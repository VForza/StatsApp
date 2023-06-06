using StatsApp.Data.Models;
using StatsApp.Dtos;
using StatsApp.Mappers;
using StatsApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StatsApp.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IStatisticsRepository _repo;

        public StatisticsService(IStatisticsRepository repo)
        {
            _repo = repo;
        }

        public List<StatisticsResponseDto> GetAllByDate(DateTime from, DateTime to)
        {
            List<Statistics> stats = _repo.FindAllByDate(from, to);
            return (from Statistics s in stats
                    select StatisticsMapper.ModelToResponse(s)).ToList();
        }

        public void CreateStatistics(StatisticsRequestDto stats)
        {
            Statistics statistics = StatisticsMapper.RequestToModel(stats);
            _repo.CreateStatistics(statistics);
        }
        public void DeleteAll()
        {
            _repo.DeleteAll();
        }
    }
}
