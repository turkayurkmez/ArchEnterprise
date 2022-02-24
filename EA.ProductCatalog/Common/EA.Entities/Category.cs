using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad boş olamaz")]
        public string Name { get; set; }

        public IList<Product> Products { get; set; }
    }
}
