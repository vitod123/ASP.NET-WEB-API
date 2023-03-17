using Core.DTOs.User;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAccountsService
    {
        Task<User> Get(string id);
        Task<LoginResponseDto> Login(LoginDto dto);
        Task Register(RegisterDto dto);
        Task Logout();
    }
}
