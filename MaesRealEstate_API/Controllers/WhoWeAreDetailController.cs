using MaesRealEstate_API.Dtos.WhoWeAreDetailDtos;
using MaesRealEstate_API.Repositories.WhoWeAreRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {

        private readonly IWhoWeAreDetailRepository _whoWeAreDetailRepository;

        public WhoWeAreDetailController(IWhoWeAreDetailRepository whoWeAreDetailRepository)
        {
            _whoWeAreDetailRepository = whoWeAreDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreDetailRepository.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            _whoWeAreDetailRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDto);
            return Ok("Hakkımızda Kısmı Başarılı Bir Şekilde Eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteWoWeAreDetail(int id)
        {
            _whoWeAreDetailRepository.DeleteWhoWeAreDetail(id);
            return Ok("Hakkımızda Kısmı Başarılı Bir Şekilde Silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWoWeAreDetail(UpdateWhoWeAreDetailDto updateWoWeAreDetailDto)
        {
            _whoWeAreDetailRepository.UpdateWhoWeAreDetail(updateWoWeAreDetailDto);
            return Ok("Hakkımızda Kısmı Başarıyla Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWoWeAreDetail(int id)
        {
            var value = await _whoWeAreDetailRepository.GetWhoWeAreDetail(id);
            return Ok(value);
        }

    }
}
