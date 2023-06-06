using StatsApp.Data.Models;
using StatsApp.Dtos;
using System;

namespace StatsApp.Mappers
{
    public class StatisticsMapper
    {
        public static Statistics RequestToModel(StatisticsRequestDto dto)
        {
            return new Statistics
            {
                Date = dto.Date,
                Views = dto.Views,
                Clicks = dto.Clicks,
                Cost = dto.Cost
            };
        }

        public static StatisticsResponseDto ModelToResponse(Statistics model)
        {
            String date = model.Date.ToString("yyyy-MM-dd");
            int? views = MapNullToZero(model.Views);
            int? clicks = MapNullToZero(model.Clicks);
            decimal? cost = RoundValue(model.Cost);
            decimal? cpc = RoundValue(model.Cpc);
            decimal? cpm = RoundValue(model.Cpm);

            return new StatisticsResponseDto
            {
                Date = date,
                Views = views,
                Clicks = clicks,
                Cost = cost,
                Cpc = cpc,
                Cpm = cpm
            };
        }

        public static StatisticsResponseDto RequestToResponse(StatisticsRequestDto dto)
        {
            return ModelToResponse(RequestToModel(dto));
        }


        private static decimal? RoundValue(decimal? value)
        {
            return value.HasValue ? Math.Ceiling((decimal)value * 100) / 100 : 0;
        }

        private static int? MapNullToZero(int? value)
        {
            return value.HasValue ? value : 0;
        }
    }
}


//if (value != null)
//{
//    value = Math.Ceiling((decimal)value * 100) / 100;
//    return value;
//}
//else
//{
//    return 0;
//}