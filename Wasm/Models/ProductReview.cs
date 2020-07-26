using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models
{
    public class ProductReview
    {
        [Required]
        public string ReviewerName { get; set; }
        [Required]
        [EmailAddress]
        public string ReviewerEmail { get; set; }
        [Required]
        public string Rate { get; set; }
        [StringLength(500)]
        public string Comment { get; set; }
    }
}
