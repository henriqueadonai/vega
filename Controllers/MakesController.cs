using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using vega.Core.Models;
using vega.Database;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly IMapper mapper;
        private readonly VegaDbContext context;
        public MakesController(VegaDbContext context,IMapper mapper){
            this.mapper = mapper;
            this.context = context;
        }


        [HttpGet("/api/makes")]
        public IEnumerable<Make> GetMakes()
        {            
            return context.Makes.ToList();
        }
    }
}