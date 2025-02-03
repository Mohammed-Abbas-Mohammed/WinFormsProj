using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.Contracts
{
    public interface ICustomerRepo
    {
        public void Create(Customer customer);
        public IQueryable<Customer> GetAll();
        public int SaveChanges();
    }
}
