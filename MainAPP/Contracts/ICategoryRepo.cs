using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.Contracts
{
    public interface ICategoryRepo
    {
        public void Create(Category category);

        public void Update(Category category);
        public void Delete(Category category);
        public Category GetByID(int id);
        public IQueryable<Category> GetAll();
        public int SaveChanges();
        public IQueryable<Category> Search(string keyWord);

    }
}
