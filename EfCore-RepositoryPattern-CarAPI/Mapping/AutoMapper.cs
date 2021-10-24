using AutoMapper;
using Cars_API.Models.Dto;
using EfCore_RepositoryPattern_CarAPI.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_RepositoryPattern_CarAPI.Mapping
{
    public class AutoMapper: Profile
    {

        public AutoMapper()
        {
            CreateMap<TodoDto, TodoDtos>();
        }

        public int CreateMap { get; }
    }
}
