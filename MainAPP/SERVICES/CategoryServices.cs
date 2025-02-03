using AutoMapper;
using DTOS;
using MainAPP.Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.SERVICES
{
    public class CategoryServices : ICategoryServices
    {
        private ICategoryRepo CategoryRepository;

        private IMapper mapper { get; }

        public CategoryServices(ICategoryRepo _CategoryRepository, IMapper _mapper)
        {
            CategoryRepository = _CategoryRepository;
            mapper = _mapper;
        }
        public CreatCategoryDTO AddOne(CreatCategoryDTO entity)
        {
            Category cat = mapper.Map<Category>(entity);
            if (entity != null)// && IsAdmin)
            {
                CategoryRepository.Create(cat);
                CategoryRepository.SaveChanges();
                return mapper.Map<CreatCategoryDTO>(cat);
            }

            return null;
        }

        public void DeleteOne(int id)
        {
            var entity = CategoryRepository.GetByID(id);
            Category cat = mapper.Map<Category>(entity);
            CategoryRepository.Delete(cat);
            CategoryRepository.SaveChanges();
        }

        public List<CreatCategoryDTO> GetAllItmes()
        {
            var CategoryList = CategoryRepository.GetAll().ToList();
            return mapper.Map<List<CreatCategoryDTO>>(CategoryList);
        }

        public List<CreatCategoryDTO> GetAllPag(int pageNumber, int count = 5)
        {
            var Cats = CategoryRepository.GetAll()
         .Skip(count * (pageNumber - 1))
         .Take(count)
         .ToList();

            return mapper.Map<List<CreatCategoryDTO>>(Cats);
        }

        public CreatCategoryDTO GetOneByID(int id)
        {
            Category cat;
            cat = CategoryRepository.GetByID(id);

            return mapper.Map<CreatCategoryDTO>(cat);
        }

        public CreatCategoryDTO GetOne(int id)
        {
            var cat = CategoryRepository.GetByID(id);
            return mapper.Map<CreatCategoryDTO>(cat);
        }

        public CreatCategoryDTO UpdateOne(int _id, CreatCategoryDTO _entity)
        {
            var entity = CategoryRepository.GetByID(_id);
            Category cat = mapper.Map<Category>(entity);
            cat.CategoryName = _entity.CategoryName;
            cat.Created = _entity.Created;
            CategoryRepository.Update(cat);
            CategoryRepository.SaveChanges();
            return mapper.Map<CreatCategoryDTO>(cat);
        }

        public List<CreatCategoryDTO> Search(string keyWord)
        {
            var prodList = CategoryRepository.Search(keyWord).ToList();
            return mapper.Map<List<CreatCategoryDTO>>(prodList);
        }
    }
}
