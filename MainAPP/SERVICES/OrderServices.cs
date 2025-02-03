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
    public class OrderServices: IOrderServices
    {
        private IOrderRepo OrderRepository;

        private IMapper mapper { get; }

        public OrderServices(IOrderRepo _ProductRepository, IMapper _mapper)
        {
            OrderRepository = _ProductRepository;
            mapper = _mapper;
        }

        public OrderDTO AddOne(OrderDTO entity)
        {
            OrderM order = mapper.Map<OrderM>(entity);
            if (entity != null)
            {
                OrderRepository.Create(order);
                OrderRepository.SaveChanges();
                return mapper.Map<OrderDTO>(order);
            }

            return null;
        }

        public List<OrderDTO> GetAllItmes()
        {
            var orderList = OrderRepository.GetAll().ToList();
            return mapper.Map<List<OrderDTO>>(orderList);
        }

        //public OrderDTO UpdateOne(int _id, OrderDTO _entity)
        //{
        //    var entity = OrderRepository.GetByID(_id);
        //    OrderM order = mapper.Map<OrderM>(entity);
        //    pro.ProductName = _entity.ProductName;
        //    pro.UnitPrice = _entity.UnitPrice;
        //    pro.UnitsInStock = _entity.UnitsInStock;

        //    OrderRepository.Update(order);
        //    OrderRepository.SaveChanges();
        //    return mapper.Map<OrderDTO>(order);
        //}
    }
}
