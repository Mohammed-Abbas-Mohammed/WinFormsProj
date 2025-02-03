using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.Contracts
{
    public interface IProductRepo
    {
        public void Create(Product entity);

        public void Update(Product entity);

        public void Delete(Product entity);
        public Product GetByID(int id);

        public IQueryable<Product> GetAll();

        public IQueryable<Product> Search(string keyWord);

        public int SaveChanges();
    }
}
