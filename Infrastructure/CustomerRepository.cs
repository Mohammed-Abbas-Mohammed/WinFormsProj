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
    public class CustomerRepository: ICustomerRepo
    {
        public readonly ProCon Context;

        public CustomerRepository(ProCon _context)
        {
            Context = _context;
        }

        public void Create(Customer entity) => Context.Customers.Add(entity);
        public IQueryable<Customer> GetAll() => Context.Customers;
        public int SaveChanges() => Context.SaveChanges();
    }
}
