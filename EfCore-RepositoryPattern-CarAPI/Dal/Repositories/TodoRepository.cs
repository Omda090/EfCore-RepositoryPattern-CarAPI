using AutoMapper;
using Cars_API.Models;
using Cars_API.Models.Dto;
using EfCore_RepositoryPattern_CarAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_RepositoryPattern_CarAPI.Dal.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly CarDbContext _ctx;
       // private TodoDto todoDto;
        private readonly IMapper _mapper;

        public TodoRepository(CarDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        

        public async Task<TodoDto> GetById(int id)
        {
          return await  _ctx.TodoDtos.FirstOrDefaultAsync(todoDto => todoDto.Id == id);
        }

        public void Remove(TodoDto exitsCountry)
        {
            _ctx.Remove(exitsCountry);
        }

       

        public async Task<bool> SaveChanges()
        {
              return await _ctx.SaveChangesAsync()>0;
        }

        public Task GetAllCarsAsync()
        {
            throw new NotImplementedException();
        }

       

        Task<List<TodoDto>> ITodoRepository.GetAllCarsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TodoDto> CreateCarAsync(TodoDto todoDto)
        {
            throw new NotImplementedException();
        }
    }
}
