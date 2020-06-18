using AutoMapper;
using Store.BLL.DTO;
using Store.BLL.Interfaces;
using Store.DAL.Entities;
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
            //User
            CreateMap<CategoryDTO, Category>();
            CreateMap<ProductDTO, Product>();
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<LoginViewModel, UserDTO>();
            CreateMap<RegisterViewModel, UserDTO>()
          .ForMember(dest => dest.Role, opts => opts.MapFrom(src => "user"));


            //Product
            CreateMap<ProductViewModel, ProductDTO>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(x => x.Name))
                .ForMember(dest => dest.ShortDescription, opts => opts.MapFrom(x => x.ShortDescription))
                .ForMember(dest => dest.Price, opts => opts.MapFrom(x => x.Price))
                .ForMember(dest => dest.ImagePath, opts => opts.MapFrom(x => x.ImagePath))
                .ForMember(dest => dest.CategoryId, opts => opts.MapFrom(x => x.CategoryId));
                


            CreateMap<RegisterViewModel, UserDTO>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
            CreateMap<UserDTO, User>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));

            CreateMap<LoginViewModel, UserDTO>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
            CreateMap<UserDTO, User>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));

            //Category
            CreateMap<CategoryDTO, Category>().ForMember(au => au.NameCategory, map => map.MapFrom(vm => vm.NameCategory));
            CreateMap<CategoryDTO, Category>().ForMember(au => au.Id, map => map.MapFrom(vm => vm.Id));

        }
    }
}
