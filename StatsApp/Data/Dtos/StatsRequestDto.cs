using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace StatsApp.Data.Dtos
{
    public class StatsRequestDto
    {
        [Required(ErrorMessage = "Date is a required field")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Views field can't be less than 0")]
        public int? Views { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Clicks field can't be less than 0")]
        public int? Clicks { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Cost filed can't be less than 0")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal? Cost { get; set; }
    }
}
