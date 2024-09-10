using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;

namespace PcGearHub.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        Task<User> CreateUserFromDto(UserDTO userDto);
        Task<UserLoginDTO> AuthenticateUser(string email, string password);
        Task<UserDetailDTO> GetUserDetails(int userId);

        Task<List<User>> GetAllIncluding(params Expression<Func<User, object>>[] includeProperties);








    }
}
