using MaesRealEstate_API.Dtos.CategoryDtos;

namespace MaesRealEstate_API.Repositories.CategoryRepository
{
    public interface IWoWeAreDetailControllerRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);   
        Task<GetByIDCategoryDto> GetCategory(int id);
    }
}
