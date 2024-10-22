﻿using MaesRealEstate_API.Dtos.BottomGridDtos;

namespace MaesRealEstate_API.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {

        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
