using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Implements;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Implements
{

    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRoleRepository _userRoleRepository;
        public UserService(IUserRepository repository, IUserRoleRepository userRoleRepository) : base(repository)
        {
            _userRoleRepository = userRoleRepository;
        }

        public async Task<UserLoginDTO> AuthenticateUser(string email, string password)
        {
            var user = await _repository.FindBy(u => u.Email == email && u.Password == password).FirstOrDefaultAsync();

            if (user == null)
            {
                return null; // Kullanıcı bulunamadı
            }

            var userLoginDTO = new UserLoginDTO
            {
             
                Email = user.Email,
                Password = user.Password,
               
                // Diğer gerekli alanlar
            };

            return userLoginDTO;
        }


        public async Task<User> CreateUserFromDto(UserDTO userDto)
        {
            // Perform the mapping inside the service layer
            var user = new User
            {

                Username = userDto.Username,
                Password = userDto.Password,
                Email = userDto.Email,
                PhoneNumber = userDto.PhoneNumber,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                RoleId = 1






            };
            await _repository.Create(user);

            var userRole = new UserRole
            {
                UserId = user.UserId,
                RoleId = 1 // Assuming 1 is the roleId you want to assign
            };


            await _userRoleRepository.Create(userRole);







            // Save to the repository or data store

            return user; // Return the created user
        }



        //public async Task<UserDTO> GetUserforLogin(UserDTO userDto)
        //{
        //    var result = await _repository.FindBy(x => x.Email == userDto.Email && x.Password == userDto.Password).FirstOrDefaultAsync();
        //    var roleId = _userRoleService.GetById()
        //    var user = new UserDTO
        //    {

        //        Username = result.Username,
        //        Password = result.Password,
        //        Email = result.Email,
        //        PhoneNumber = result.PhoneNumber,
        //        FirstName = result.FirstName,
        //        LastName = result.LastName,




        //    };

        //}



    }
}
