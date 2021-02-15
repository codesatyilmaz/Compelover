using System.Collections.Generic;
using AutoMapper;
using Compelover.Entities.DTOs;
using Compelover.Entities.Tangible;
using Compelover.WEBUI.ViewModels;

namespace Compelover.WEBUI.AutoMapping
{
    public class AutoMapProfile:Profile
    {
        public AutoMapProfile()
        {
            CreateMap<AppUser, UserViewModel>();
            CreateMap<UserViewModel, AppUser>();
            CreateMap<Blog, BlogDto>();
            CreateMap<BlogDto, Blog>();
            CreateMap<BlogUserDto, Blog>();
            CreateMap<Blog, BlogUserDto>();
            CreateMap<AppUser, Blog>();
            CreateMap<Blog, AppUser>();
            CreateMap<BlogUserDto, Blog>();
            CreateMap<Blog, BlogUserDto>();
            CreateMap<BlogUserDto, AppUser>();
            CreateMap<AppUser, BlogUserDto>();
            CreateMap<UserListDto, AppUser>();
            CreateMap<AppUser, UserListDto>();
            // CreateMap<AppRole, RoleViewModel>();
            // CreateMap<RoleViewModel, AppRole>();
        }
    }
}