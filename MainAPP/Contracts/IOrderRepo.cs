using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.Contracts
{
    public interface IOrderRepo
    {
        public void Create(OrderM entity);

        public void Update(OrderM entity); // status

        public IQueryable<OrderM> GetAll();

        public int SaveChanges();
    }
}
