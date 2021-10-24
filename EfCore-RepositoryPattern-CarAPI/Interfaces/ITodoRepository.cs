using Cars_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_RepositoryPattern_CarAPI.Interfaces
{
     public interface ITodoRepository
    {

        Task<List<TodoDto>> GetAllCarsAsync();
        Task<TodoDto> GetById(int id);

        Task<TodoDto> CreateCarAsync(TodoDto todoDto);
        void Remove(TodoDto exitsCountry);

        Task<bool> SaveChanges();
       // Task GetAllCarsAsync();
    }
}
