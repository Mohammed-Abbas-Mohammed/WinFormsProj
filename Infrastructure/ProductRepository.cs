
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
    public class ProductRepository : IProductRepo
    {
        public readonly ProCon Context;

        public ProductRepository(ProCon _context)
        {
            Context = _context;
        }

        public void Create(Product entity) => Context.Products.Add(entity);

        public void Delete(Product entity) => Context.Products.Remove(entity);

        public IQueryable<Product> GetAll() => Context.Products;

        public Product GetByID(int id) => Context.Products.FirstOrDefault(p => p.ProductID == id);

        public IQueryable<Product> Search(string keyWord) => Context.Products.Where(p => p.ProductName.Contains(keyWord));

        public void Update(Product entity) => Context.Products.Update(entity);

        public int SaveChanges() => Context.SaveChanges();
    }
}
