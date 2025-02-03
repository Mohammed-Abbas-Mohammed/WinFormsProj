using DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.SERVICES
{
    public interface ICustomerServices
    {
        public CustomerDTO AddOne(CustomerDTO entity);
        public List<CustomerDTO> GetAllItmes();
 

    }
}
