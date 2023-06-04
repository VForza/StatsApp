using StatsApp.Data.Dtos;
using StatsApp.Data.Models;
using System;
using System.Collections.Generic;

namespace StatsApp.Repositories
{
    public interface IStatisticsRepository
    {
        IEnumerable<StatsResponseDto> GetAllByDate(DateTime from, DateTime to);
        Statistics GetByDate(DateTime date);
        void Create(StatsRequestDto stat);
        void Update(StatsRequestDto stat);
        void DeleteAll();
    }
}
