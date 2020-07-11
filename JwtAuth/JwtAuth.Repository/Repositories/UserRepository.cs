using JwtAuth.Domain.Entities;
using JwtAuth.Repository.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JwtAuth.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly IMongoDbContext _mongoDbContext;

        public UserRepository(IMongoDbContext mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
        }

        private IMongoCollection<User> GetCollection() => _mongoDbContext.MongoDatabase.GetCollection<User>("users");

        public async Task Create(User user)
        {
            await GetCollection().InsertOneAsync(user);
        }

        public async Task<List<User>> GetAll()
        {
            var result = await GetCollection().Find(_ => true).ToListAsync();

            return result;
        }

        public Task<User> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
