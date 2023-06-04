using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using StatsApp.Data.Models;
using StatsApp.Dtos;
using System;
using System.Threading;

namespace StatsApp.Mappers
{
    public class StatsMapper
    {
        public static Statistics RequestToModel(StatsRequestDto dto)
        {
            return new Statistics 
            {
                Date = dto.Date, Views = dto.Views, Clicks = dto.Clicks, Cost = dto.Cost
            };
        }

        public static StatsResponseDto ModelToResponse(Statistics model)
        {
            String date = model.Date.ToString("yyyy-MM-dd");
            decimal? cost = RoundValue(model.Cost);
            decimal? cpc = RoundValue(model.Cpc);
            decimal? cpm = RoundValue(model.Cpm);

            return new StatsResponseDto 
            {
                Date = date, Views = model.Views, Clicks = model.Clicks, Cost = cost, Cpc = cpc, Cpm = cpm
            };
        }

        private static decimal? RoundValue(decimal? value)
        {
            if (value != null) value = Math.Ceiling((decimal)value * 100) / 100;
            return value;
        }
    }
}
