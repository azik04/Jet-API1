﻿using Jet_API1.Model;
using Jet_API1.Response;
using Jet_API1.ViewModel.Places;

namespace Jet_API1.Services.Interfaces
{
    public interface IPlaceService
    {
        Task<BaseResponse<Place>> Create(CreatePalaceVM city);
        BaseResponse<IQueryable<Place>> GetAll();
        Task<BaseResponse<Place>> Get(int id);
        Task<BaseResponse<Place>> Update(Place city);
        Task<BaseResponse<Place>> Delete(int id);
    }
}