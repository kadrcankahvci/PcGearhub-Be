using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;

namespace PcGearHub.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        Task<User> CreateUserFromDto(UserDTO userDto);
        //Task<User> AuthenticateUser(string email, string password);

    }
}
