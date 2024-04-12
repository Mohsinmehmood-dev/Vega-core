using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Vega.net.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FeatureResource>>> Get()
        {
            var features = await context.Features.ToListAsync();

            var featureResources = mapper.Map<IEnumerable<FeatureResource>>(features);

            return Ok(featureResources);
        }

    }
}

