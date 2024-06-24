using Dapper;
using MaesRealEstate_API.Dtos.WhoWeAreDetailDtos;
using MaesRealEstate_API.Models.DapperContext;

namespace MaesRealEstate_API.Repositories.WhoWeAreRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;
        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }
        public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail (Title,SubTitle,Description1,Description2) values (@title,@subtitle,@description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createWoWeAreDetailDto.Title);
            parameters.Add("@subtitle", createWoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", createWoWeAreDetailDto.Description1);
            parameters.Add("@description2", createWoWeAreDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetail(int id)
        {
            string query = "Delete From WhoWeAreDetail Where WoWeAreDetailID=@woWoAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@woWoAreDetailID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * From WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id)
        {
            string query = "Select * From WhoWeAreDetail Where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDetailDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWoWeAreDetailDto)
        {
            string query = "Update WhoWeAreDetail Set Title=@title,SubTitle=@subtitle,Description1=@description1,Description2=@description2 where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWoWeAreDetailDto.Title);
            parameters.Add("@subtitle", updateWoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", updateWoWeAreDetailDto.Description1);
            parameters.Add("@description2", updateWoWeAreDetailDto.Description2);
            parameters.Add("@whoWeAreDetailID", updateWoWeAreDetailDto.WhoWeAreDetailID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
