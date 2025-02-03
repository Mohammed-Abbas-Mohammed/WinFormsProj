using AutoMapper;
using DTOS;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.Mapp
{
    public class AutoMapperPro:Profile
    {
        public AutoMapperPro()
        {
            CreateMap<Product, AdminProductDTO>().ReverseMap();
            CreateMap<Product, ClientProductDTO>().ReverseMap();
            CreateMap<CreatCategoryDTO, Category>().ReverseMap();
            CreateMap<OrderDTO, OrderM>().ReverseMap();
            CreateMap<CustomerDTO, Customer>().ReverseMap();
        }


    }
}
