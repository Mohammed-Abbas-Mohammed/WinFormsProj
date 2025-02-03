using DbCont;
using MainAPP.Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class OrderRepository: IOrderRepo
    {
        public readonly ProCon Context;

        public OrderRepository(ProCon _context)
        {
            Context = _context;
        }
        public void Create(OrderM entity) => Context.orders.Add(entity);
        public IQueryable<OrderM> GetAll() => Context.orders;

        public void Update(OrderM entity) => Context.orders.Update(entity);

        public int SaveChanges() => Context.SaveChanges();
    }
}
