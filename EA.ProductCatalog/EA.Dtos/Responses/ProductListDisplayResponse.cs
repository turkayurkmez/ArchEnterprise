using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.Dtos.Responses
{
   public class ProductListDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public string ImageUrl { get; set; }

        public byte[] RowVersion { get; set; }

    }
}
