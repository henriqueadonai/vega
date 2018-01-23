using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using vega.Core.Models;
using vega.Database;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        //private readonly IMapper mapper;
        private readonly VegaDbContext context;
        public MakesController(VegaDbContext context){
            //this.mapper = mapper;, IMapper mapper
            this.context = context;
        }


        [HttpGet("/api/makes")]
        public IEnumerable<Make> GetMakes()
        {
            
            return null;
        }
    }
}