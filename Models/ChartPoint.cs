using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrowthDashboard.Models
{
    [Keyless]
    public class ChartPoint
    {
        [Column("Year")]
        public string Label { get; set; }

        [Column("TotalEmployees")]
        public int Value { get; set; }
    }
}
