using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<Product, ProductModel>();
            CreateMap<Product_Type, Product_TypeModel>();
            CreateMap<Product_Type, Product_TypeDetails>();
        }
    }
}
