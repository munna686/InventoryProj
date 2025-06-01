using InvenotryProj.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj.Services.Interface
{
    public interface IUserService
    {
        Task<ServiceResponse> Login(LoginDTO dto);
        Task<ServiceResponse> Logout();
    }
}
