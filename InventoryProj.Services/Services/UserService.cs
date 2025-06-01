using InvenotryProj.Core.DTOs;
using InvenotryProj.Core.Interfaces;
using InvenotryProj.Core.Model;
using InventoryProj.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Utility;

namespace InventoryProj.Services.Services
{
    public class UserService : IUserService
    {
        private readonly  IUnitOfWork unitOfWork;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public UserService(IUnitOfWork unitOfWork,SignInManager<ApplicationUser> signInManager)
        {
            this.unitOfWork = unitOfWork;
            this._signInManager = signInManager;
        }

        public async Task<ServiceResponse> Login(LoginDTO dto)
        {
            var user = await unitOfWork.User.FindByEmailAsync(dto.Email);
            if (user == null) return ResponseUtility.SendLoginFail(dto);
            var success = await unitOfWork.User.CheckPasswordAsync(user,dto.Password);
            if (!success) return ResponseUtility.SendLoginFail(dto);
            await _signInManager.SignInAsync(user,isPersistent: false);
            return ResponseUtility.SendLoginSuccess(dto);
        }

        public async Task<ServiceResponse> Logout()
        {
            await _signInManager.SignOutAsync();
            return ResponseUtility.SendLogOutSuccess(true);
        }
    }
}
