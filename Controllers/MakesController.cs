using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega;

namespace Vega.net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public MakesController(VegaDbContext context , IMapper  mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes =  await context.Makes.Include(m => m.Models).ToListAsync();

            var MakeResource = mapper.Map<IEnumerable<MakeResource>>(makes);

            return MakeResource;


        }    

         
        
    }
}
