﻿using Jet_API1.Model;
using Jet_API1.Response;
using Jet_API1.ViewModel.Cityes;
using Jet_API1.ViewModel.Places;
using Jet_API1.ViewModel.Region;

namespace Jet_API1.Services.Interfaces
{
    public interface IRegionService
    {
        Task<BaseResponse<Region>> Create(CreateRegionVM region);
        BaseResponse<IQueryable<Region>> GetAll();
        Task<BaseResponse<Region>> Get(int id);
        Task<BaseResponse<Region>> Update(Region region, int id);
        Task<BaseResponse<Region>> Delete(int id);
    }
}