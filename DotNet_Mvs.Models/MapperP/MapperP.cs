using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DotNet_Mvc.Models.Dto;

namespace DotNet_Mvc.Models.MapperP
{
    public class MapperP:Profile
    {
        public MapperP() {
            CreateMap<CategoryDto, Category>().ReverseMap();
        }
    }
}
