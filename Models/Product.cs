using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public byte[]? ProductImage { get; set; }

        public Category Category { get; set; }

        public ICollection<OrderM> orders { get; set; }
    }
}
