using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.Dtos.Requests
{
   public class AddProductRequest
    {
        [Required(ErrorMessage ="Ad boş olmasın")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
        public float Discount { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
