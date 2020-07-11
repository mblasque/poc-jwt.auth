using JwtAuth.Domain.Entities;
using JwtAuth.Repository.Interfaces;
using JwtAuth.Services.Implementations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JwtAuth.Services.Interfaces
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Create(User user)
        {
            await _userRepository.Create(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public Task<User> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
