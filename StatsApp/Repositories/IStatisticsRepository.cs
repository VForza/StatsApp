using StatsApp.Data.Models;
using StatsApp.Dtos;
using System;
using System.Collections.Generic;

namespace StatsApp.Repositories
{
    public interface IStatisticsRepository
    {
        IEnumerable<StatsResponseDto> GetAllByDate(DateTime from, DateTime to);
        Statistics GetByDate(DateTime date);
        void Create(StatsRequestDto stat);
        void DeleteAll();
    }
}
