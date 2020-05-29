using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace day5Assignment.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int MRC { get; set; }
        [Required]
        public int NRC { get; set; }
        
        public int Discount { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        
        public DateTime? CreatedDate { get; set; }
    }
}
