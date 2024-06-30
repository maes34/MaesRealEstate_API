using Dapper;
using MaesRealEstate_API.Dtos.TestimonialDtos;
using MaesRealEstate_API.Models.DapperContext;

namespace MaesRealEstate_API.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : ITestimonialRepository
    {

        private readonly Context _context;
        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "Select * From Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }
    }
 
}
