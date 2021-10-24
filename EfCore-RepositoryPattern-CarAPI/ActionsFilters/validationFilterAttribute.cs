using Cars_API.Models;
using EfCore_RepositoryPattern_CarAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace EfCore_RepositoryPattern_CarAPI.ActionsFilters
//{
    //public class validationFilterAttribute : IActionFilter
    //{

        //public void OnActionExcuting(CarDbContext context)
        //{
        //    var param = context.ActionArguments.SingleOrDefault(p => p.Value is ITodoRepository) ;
        //    if(param.Value == null)
        //    {
        //        context.Result = new BadRequestObjectResult("Object is Null");
        //        return;
        //    }

        //    if(!context.isModelState.IsValid)
        //    {
        //        context.Result = new BadRequestObjectResult(context.ModelState);
        //    }


        //}

        //public void OnActionExcuted(CarDbContext context)
        //{

        //}
//    }
//}
