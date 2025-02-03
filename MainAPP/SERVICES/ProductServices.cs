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
    public class ProductServices :IProductServices
    {
        private IProductRepo ProductRepository;

        private IMapper mapper { get; }

        public ProductServices(IProductRepo _ProductRepository, IMapper _mapper)
        {
            ProductRepository = _ProductRepository;
            mapper = _mapper;
        }
        public AdminProductDTO AddOne(AdminProductDTO entity)
        {
            Product pro = mapper.Map<Product>(entity);
            if (entity != null)// && IsAdmin)
            {
                ProductRepository.Create(pro);
                ProductRepository.SaveChanges();
                return mapper.Map<AdminProductDTO>(pro);
            }

            return null;
        }

        public void DeleteOne(int id)
        {
            var entity= ProductRepository.GetByID(id); 
            Product pro = mapper.Map<Product>(entity);
            ProductRepository.Delete(pro);
            ProductRepository.SaveChanges();
        }

        public List<AdminProductDTO> GetAllItmes()
        {
            var productList = ProductRepository.GetAll().ToList();
            return mapper.Map<List<AdminProductDTO>>(productList);
        }

        public List<ClientProductDTO> GetAllPag(int pageNumber, int count = 5)
        {
            var products = ProductRepository.GetAll()
         .Skip(count * (pageNumber - 1))
         .Take(count)
         .ToList();

            return mapper.Map<List<ClientProductDTO>>(products);
        }

        public AdminProductDTO GetOneByID(int id)
        {
            Product pro;
            pro = ProductRepository.GetByID(id);

            return mapper.Map<AdminProductDTO>(pro);
        }

        public ClientProductDTO GetOne(int id)
        {
            var pro = ProductRepository.GetByID(id);
            return mapper.Map<ClientProductDTO>(pro);
        }

        public AdminProductDTO UpdateOne(int _id, AdminProductDTO _entity)
        {
            var entity = ProductRepository.GetByID(_id);
            Product pro = mapper.Map<Product>(entity);
            pro.ProductName = _entity.ProductName;
            pro.UnitPrice = _entity.UnitPrice;
            pro.UnitsInStock = _entity.UnitsInStock;

            ProductRepository.Update(pro);
            ProductRepository.SaveChanges();
            return mapper.Map<AdminProductDTO>(pro);
        }

        public List<ClientProductDTO> Search(string keyWord)
        {
            var prodList = ProductRepository.Search(keyWord).ToList();
            return mapper.Map<List<ClientProductDTO>>(prodList);
        }

   
    }
}
