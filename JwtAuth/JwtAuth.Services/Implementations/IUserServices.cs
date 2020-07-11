using System.Threading.Tasks;
using JwtAuth.Domain.Entities;
using System.Collections.Generic;

namespace JwtAuth.Services.Implementations
{
    public interface IUserServices
    {
        Task Create(User user);

        Task<User> GetById(int id);

        Task<List<User>> GetAll();
    }
}
