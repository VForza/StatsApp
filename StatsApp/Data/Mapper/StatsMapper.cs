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
            decimal? cpc = (model.Cost / model.Clicks);
            decimal? cpm = (model.Cost / model.Views);
            return new StatsResponseDto 
            {
                Date = model.Date, Views = model.Views, Clicks = model.Clicks, Cost = model.Cost, Cpc = cpc, Cpm = cpm
            };
        }
    }
}
