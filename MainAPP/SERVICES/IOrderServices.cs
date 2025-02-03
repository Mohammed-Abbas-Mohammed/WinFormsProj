using DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.SERVICES
{
    public interface IOrderServices
    {
        public OrderDTO AddOne(OrderDTO entity);

        //public OrderDTO UpdateOne(int id, OrderDTO entity);

        public List<OrderDTO> GetAllItmes();
 
    }
}
