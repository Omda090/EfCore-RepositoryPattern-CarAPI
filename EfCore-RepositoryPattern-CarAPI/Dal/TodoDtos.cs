using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_RepositoryPattern_CarAPI.Dal
{
    public class TodoDtos
    {
        public string CarName { get; set; }
        public long Model { get; set; }
        public string Desc { get; set; }
    }
}
