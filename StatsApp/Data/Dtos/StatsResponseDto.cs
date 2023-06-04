using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StatsApp.Data.Dtos
{
    public class StatsResponseDto
    {
        public DateTime Date { get; set; }
        public int? Views { get; set; }
        public int? Clicks { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Cpc { get; set; }
        public decimal? Cpm { get; set; }

    }
}
