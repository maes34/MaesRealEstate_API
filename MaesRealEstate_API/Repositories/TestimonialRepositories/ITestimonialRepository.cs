using MaesRealEstate_API.Dtos.TestimonialDtos;

namespace MaesRealEstate_API.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
