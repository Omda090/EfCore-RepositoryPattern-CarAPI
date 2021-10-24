using AutoMapper;
using Cars_API.Models;
using Cars_API.Models.Dto;
using EfCore_RepositoryPattern_CarAPI.Dal;
using EfCore_RepositoryPattern_CarAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodItemController : ControllerBase
    {
        // List<TodoDto> todoDto = new List<TodoDto>();
        //   List<TodoItem> todoItems = new List<TodoItem>();

        private readonly ITodoRepository _todo;
        private readonly CarDbContext _carDbContext;
        private readonly IMapper _mapper;

        [ActivatorUtilitiesConstructor]
        public TodItemController(ITodoRepository todo, IMapper mapper)
        {
            _todo = todo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]String FilterCarName)
        {
            var CarQuery = _carDbContext.TodoDtos.AsQueryable();
            CarQuery = CarQuery.Where(x => x.CarName == "Mistobishee");

            if (!String.IsNullOrWhiteSpace(FilterCarName))
            {
                CarQuery = CarQuery.Where(x => x.CarName.Equals(FilterCarName));

            }

            return Ok(CarQuery.Select(p => _mapper.Map<TodoDtos>(p)));

           // var items = await _todo.GetAllCarsAsync();
            //return Ok(items);
            
  



        }


        [HttpGet("{getById}")]

        public async Task< IActionResult> GetById(int id)
        {
           // var D = _carDbContext.TodoDtos.FirstOrDefault(a => a.Id == id);

            //if (D == null)
              //  return NotFound();
            return Ok(await _todo.GetById(id));
        }

        
        //Filtering by Using Linq : Example
        
        //[HttpGet("{getByModel}")]
        //public IEnumerable<TodoDto> Linq()
        //{
        //    var linq = from 1 in _carDbContext.Model.Where(l => l.Model > 2005 && l.CarName == "Accent")
        //        select l;
        //    return linq.ToList();
        //}



        [HttpPost]
     //   [ServiceFilter(typeof(validationFilterAttribute))]
        public async Task<IActionResult> CreateCar(TodoDtos todoDtos)
        {
            var x = new TodoDto
            {
                CarName = todoDtos.CarName,
                Model = todoDtos.Model,
                Desc = todoDtos.Desc

            };
             await _todo.CreateCarAsync(x);
            // await _todo.SaveChanges();

            //return Ok(await _todo.CreateCarAsync(x));
            return Ok(x);

        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //var exitsCountry = await _todo.TodoDtos.FirstOrDefaultAsync(x => x.Id == id);
             var exitsCountry = await _todo.GetById(id);


            //check if Car exit or not 
            if (exitsCountry != null)
            {
                _todo.Remove(exitsCountry);

                //save changes
                //  _todo.SaveChanges();
                await _todo.SaveChanges();
              //  return await _ctx.SaveChangesAsync() > 0;


                return Ok("Car Deleted Successfully");
            }
            else
            {
                return NotFound();
            }
        }


          [HttpPut("{id}")]
      //  [ServiceFilter(typeof(validationFilterAttribute))]

        public async Task<IActionResult> UpdateCountry(int id, TodoDto todoDto)
        {
            //Get Cars From Database
           // var dbCountry = await _todo.TodoDtos.FirstOrDefaultAsync(x=> x.Id == id);
            var exitsCountry = await _todo.GetById(id);


            //Update Cars Detials
            exitsCountry.CarName = todoDto.CarName;
            exitsCountry.Model = todoDto.Model;
            exitsCountry.Desc = todoDto.Desc;

            //Save Changes
            await _todo.SaveChanges();


            return Ok("Car Updated Successfully ");
        }


       

    }
}
    

