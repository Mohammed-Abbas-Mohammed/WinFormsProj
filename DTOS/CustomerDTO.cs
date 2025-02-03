using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS
{
    public class CustomerDTO
    {
        [Key]
        public int CustomerId { get; set; }

        [MaxLength(15)]
        public string FirsName { get; set; }
        [MaxLength(15)]
        public string LastName { get; set; }


        public string? Coutry { get; set; } = "Egypt";
        public string? Address { get; set; }

        [Phone]
        public int PhoneNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
