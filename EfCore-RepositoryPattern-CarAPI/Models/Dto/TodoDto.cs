using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_API.Models.Dto
{
    public class TodoDto
    {
        public long Id { get; set; }

        public string CarName { get; set; }
        public long Model { get; set; }
        public string Desc { get; set; }
        public int PageNumber { get; internal set; }
        public int PageSize { get; internal set; }

       
    }
}
