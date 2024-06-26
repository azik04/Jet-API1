﻿using Jet_API1.Response;
using Jet_API1.ViewModel.Account;
using Microsoft.AspNetCore.Identity;

namespace Jet_API1.Services.Interfaces; 

public interface IUserService
{
    Task<BaseResponse<IdentityUser>> Register(AccountVM account);
    Task<BaseResponse<IdentityUser>> LogIn(AccountVM account);
    Task<BaseResponse<ICollection<IdentityUser>>> GetAllUsers();
    Task<BaseResponse<IdentityUser>> UpdateRole(string userName, string userRole);
    Task<BaseResponse<IdentityUser>> GetUser(string username);
    Task<BaseResponse<IdentityUser>> CreateRole();
    Task<BaseResponse<List<IdentityUser>>> GetAllUserByRoles(string userRole);
}
