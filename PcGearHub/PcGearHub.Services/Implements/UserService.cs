using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Implements;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.ConvertDTO;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Implements
{

    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IAddressRespository _addressRespository;
        private readonly IOrderRepository _orderRepository;

        public UserService(IUserRepository repository, IUserRoleRepository userRoleRepository, IAddressRespository addressRespository, IOrderRepository orderRepository) : base(repository)
        {
            _userRoleRepository = userRoleRepository;
            _addressRespository = addressRespository;
            _orderRepository = orderRepository;
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
                UserId = user.UserId,
                Email = user.Email,
                Password = user.Password,
                UserRoleId = user.RoleId,

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
                RoleId = 1
            };


            await _userRoleRepository.Create(userRole);


            return user; // Return the created user
        }

        public async Task<List<User>> GetAllIncluding(params Expression<Func<User, object>>[] includeProperties)
        {
            return await _repository.GetAllIncluding(
                 u => u.Addresses,
                 u => u.Orders
             );
        }

        public async Task<UserDetailDTO> GetUserDetails(int userId)
        {
            var user = await _repository.FindBy(u => u.UserId == userId).FirstOrDefaultAsync();

            if (user == null)
            {
                return null; // Kullanıcı bulunamadı
            }

            // Kullanıcının adreslerini çek
            var addresses = await _addressRespository.FindBy(a => a.UserId == user.UserId).ToListAsync();
            var addressDTOs = addresses.Select(a => new AddressDTO
            {

                Street = a.Street,
                City = a.City,
                State = a.State,

                // Diğer adres alanları
            }).ToList();

            // Kullanıcının siparişlerini çek
            var orders = await _orderRepository.FindBy(o => o.UserId == user.UserId).ToListAsync();
            var orderDTOs = orders.Select(o => new OrderDTO
            {
                OrderId = o.OrderId,

                OrderStatus = o.Status,
                TotalAmount = o.TotalAmount,
                // Diğer sipariş detayları
            }).ToList();

            // Kullanıcı bilgilerini oluştur  
            return new UserDetailDTO
            {

                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Addresses = addressDTOs,
                Orders = orderDTOs
            };
        }
       






        public async Task<User> GetIncluded(int userId)
        {
            var query = await _repository.GetIncluded(u => u.Addresses,
                      u => u.Orders);
            return await query.FirstOrDefaultAsync(x=>x.UserId == userId);
            

        }

        public async Task<UserDTO> UpdateUser(UserDTO userDTO)
        {
            var existinguser = await GetById(userDTO.UserId);
            if (existinguser == null)
            {
                return null; 
            }
            existinguser.Username = userDTO.Username;
            existinguser.Email = userDTO.Email;
            existinguser.PhoneNumber = userDTO.PhoneNumber;
            existinguser.FirstName = userDTO.FirstName;
            existinguser.LastName = userDTO.LastName;
            existinguser.Password = userDTO.Password;
            existinguser.RoleId = userDTO.RoleId;//BURAYI CABIR ABIYE SOR!! 
            // BUNU YAPMASSAM DBSETIN TRACKED EDILMESINDE PROBLEM CIKIYOR AYNI ANDA 2 TANE USERI TAKIP EDEMEME HATASI ALIYORUM
            await _repository.Update(existinguser);
            var dto = Mapper.ToUserDTO(existinguser);
            return dto;

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
