using System;
using System.ComponentModel.DataAnnotations;

namespace StatsApp.Data.Models
{
    public class Statistics
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Date is a required field")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime Date { get; set; }
        public int? Views { get; set; }
        public int? Clicks { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Cpc
        {
            get { return Cost / Clicks; }
            set { }
        }
        public decimal? Cpm
        {
            get { return Cost / Views * 1000; }
            set { }
        }
    }
}
