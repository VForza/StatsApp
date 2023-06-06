using StatsApp.Dtos;
using System;
using System.Collections.Generic;

namespace StatsApp.Services
{
    public interface IStatisticsService
    {
        public List<StatisticsResponseDto> GetAllByDate(DateTime from, DateTime to);
        void CreateStatistics(StatisticsRequestDto stats);
        public void DeleteAll();
    }
}
