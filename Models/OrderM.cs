using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderM
    {
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        [MaxLength(20)]
        public Statusss? Status { get; set; } = Statusss.Processing;

        public int TotalPrice { get; set; }

        public Customer? Customer { get; set; } 
        public ICollection<Product> products { get; set; }
    }
}

public enum Statusss
{
    InCart,
    Processing,
    Delivered
}
