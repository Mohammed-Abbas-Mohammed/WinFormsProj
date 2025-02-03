using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public int CategoryId { get; set; }
   
        [MaxLength(15)]
        public string CategoryName { get; set; }

        public DateTime? Created { get; set; }
        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
