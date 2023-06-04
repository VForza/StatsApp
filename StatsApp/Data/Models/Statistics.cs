using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(12,2)")]
        public decimal? Cost { get; set; }
    }
}
