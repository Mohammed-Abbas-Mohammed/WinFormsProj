
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS
{
    public class AdminProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        //public byte[]? ProductImage { get; set; }
        public Category Category { get; set; }
    }
}
