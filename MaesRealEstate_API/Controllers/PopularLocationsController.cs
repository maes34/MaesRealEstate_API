using MaesRealEstate_API.Repositories.BottomGridRepositories;
using MaesRealEstate_API.Repositories.PopularLocationRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _locationRepository;

        public PopularLocationsController(IPopularLocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _locationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }
    }
}
