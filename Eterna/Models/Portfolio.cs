using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }
        public List<PortfolioImage> PortfolioImages { get; set; }
    }
}
