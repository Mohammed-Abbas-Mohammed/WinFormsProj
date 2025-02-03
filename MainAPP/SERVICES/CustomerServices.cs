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
    public class CustomerServices: ICustomerServices
    {
        private ICustomerRepo CustomerRepository;

        private IMapper mapper { get; }

        public CustomerServices(ICustomerRepo _ProductRepository, IMapper _mapper)
        {
            CustomerRepository = _ProductRepository;
            mapper = _mapper;
        }
        public CustomerDTO AddOne(CustomerDTO entity)
        {
            Customer cust = mapper.Map<Customer>(entity);
            if (entity != null)
            {
                CustomerRepository.Create(cust);
                CustomerRepository.SaveChanges();
                return mapper.Map<CustomerDTO>(cust);
            }

            return null;
        }

        public List<CustomerDTO> GetAllItmes()
        {
            var productList = CustomerRepository.GetAll().ToList();
            return mapper.Map<List<CustomerDTO>>(productList);
        }
    }
}
