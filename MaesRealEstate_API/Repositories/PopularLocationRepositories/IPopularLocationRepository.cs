using MaesRealEstate_API.Dtos.PopularLocationDtos;

namespace MaesRealEstate_API.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
    }
}
