﻿using Dapper;
using MaesRealEstate_API.Dtos.CategoryDtos;
using MaesRealEstate_API.Models.DapperContext;

namespace MaesRealEstate_API.Repositories.CategoryRepository
{
    public class CategoryRepository : IWoWeAreDetailControllerRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        { 
        _context = context; 
        }

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName, CategoryStatus) values (@categoryName, @categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "Delete From Category Where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID", id);
            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDCategoryDto> GetCategory(int id)
        {
            string query = "Select * From Category Where CategoryID=@CategoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryID", id);
            using (var connection = _context.CreateConnection())
            {
               var values = await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDto>(query, parameters);
               return values;

            }
        }

        public async void UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "Update Category Set CategoryName=@categoryName,CategoryStatus=@categoryStatus where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID", categoryDto.CategoryID);
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", categoryDto.CategoryStatus);
            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
