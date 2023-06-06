using StatsApp.Data.Models;
using System;
using System.Collections.Generic;

namespace StatsApp.Repositories
{
    public interface IStatisticsRepository
    {
        List<Statistics> FindAllByDate(DateTime from, DateTime to);
        void CreateStatistics(Statistics statistics);
        void DeleteAll();
    }
}
