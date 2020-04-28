using AutoMapper;
using Store.BLL.Interfaces;
using StoreAPI.asp.net.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.asp.net.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {




            //Product
            CreateMap<ProductViewModel, ProductDTO>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(x => x.Name))
                .ForMember(dest => dest.ShortDescription, opts => opts.MapFrom(x => x.ShortDescription))
                .ForMember(dest => dest.Price, opts => opts.MapFrom(x => x.Price));
           
        }
    }
}
