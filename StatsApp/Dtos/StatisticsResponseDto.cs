namespace StatsApp.Dtos
{
    public class StatisticsResponseDto
    {
        public string Date { get; set; }
        public int? Views { get; set; }
        public int? Clicks { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Cpc { get; set; }
        public decimal? Cpm { get; set; }
    }
}
