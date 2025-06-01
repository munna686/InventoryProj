using InvenotryProj.Core.DTOs;
using InventoryProj.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Utility;

namespace InventoryProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService userService;
        public UserController(IUserService userService) => this.userService = userService;
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO dto)
            => this.CustomApiResponse(await userService.Login(dto));
        [HttpPost("logout")]
        public async Task<IActionResult> LogOut()
            => this.CustomApiResponse(await userService.Logout());
    }
}
