using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Minimum length of Symbol must be 2 characters.")]
        [MaxLength(5, ErrorMessage = "Maximum length of Symbol can't be over 5 characters.")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MinLength(2, ErrorMessage = "Minimum length of CompanyName must be 2 characters.")]
        [MaxLength(50, ErrorMessage = "Maximum length of CompanyName can't be over 50 characters.")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1,10000000000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.01, 100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimum length of Industry must be 3 characters.")]
        [MaxLength(30, ErrorMessage = "Maximum length of Industry can't be over 30 characters.")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(0,100000000)]
        public long MarketCap { get; set; }
    }
}