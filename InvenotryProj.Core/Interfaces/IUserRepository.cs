﻿using InvenotryProj.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenotryProj.Core.Interfaces
{
    public interface IUserRepository : IGenericRepository<ApplicationUser>    
    {
        Task<ApplicationUser?> FindByEmailAsync(string email);
        Task<bool> CheckPasswordAsync(ApplicationUser user, string password);
    }
}
