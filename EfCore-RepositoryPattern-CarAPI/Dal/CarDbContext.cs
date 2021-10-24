using Cars_API.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_API.Models
{
    public class CarDbContext:DbContext
    {

        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {

        }

        //public CarDbContext()
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
         
            //....
        }

        public DbSet<TodoDto> TodoDtos { get; set; }
        public BadRequestObjectResult Result { get; internal set; }

        internal static void commet()
        {
            throw new NotImplementedException();
        }

        internal static void Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal CarDbContext Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
