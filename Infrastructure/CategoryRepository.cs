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
    public class CategoryRepository: ICategoryRepo
    {
        public readonly ProCon Context;

        public CategoryRepository(ProCon _context)
        {
            Context = _context;
        }

        public void Create(Category entity) => Context.Categories.Add(entity);

        public void Delete(Category entity) => Context.Categories.Remove(entity);

        public IQueryable<Category> GetAll() => Context.Categories;

        public Category GetByID(int id) => Context.Categories.FirstOrDefault(p => p.CategoryId == id);

        public IQueryable<Category> Search(string keyWord) => Context.Categories.Where(p => p.CategoryName.Contains(keyWord));

        public void Update(Category entity) => Context.Categories.Update(entity);

        public int SaveChanges() => Context.SaveChanges();
    }
}

