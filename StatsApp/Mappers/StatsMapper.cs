using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using StatsApp.Data.Dtos;
using StatsApp.Data.Models;
using System;
using System.Threading;

namespace StatsApp.Data.Mapper
{
    public class StatsMapper
    {
        public static Statistics ReqToModel(StatsRequestDto dto)
        {
            return new Statistics 
            {
                Date = dto.Date, Views = dto.Views, Clicks = dto.Clicks, Cost = dto.Cost
            };
        }

        public static StatsResponseDto ModelToResponse(Statistics model)
        {
            String date = model.Date.ToString("yyyy-MM-dd");
            decimal? cost = ParseValue(model.Cost);
            decimal? cpc = ParseValue(model.Cpc);
            decimal? cpm = ParseValue(model.Cpm);

            return new StatsResponseDto 
            {
                Date = date, Views = model.Views, Clicks = model.Clicks, Cost = cost, Cpc = cpc, Cpm = cpm
            };
        }

        private static decimal? ParseValue(decimal? value)
        {
            if (value != null) value = Math.Round((decimal)value, 2);
            return value;
        }
    }
}
