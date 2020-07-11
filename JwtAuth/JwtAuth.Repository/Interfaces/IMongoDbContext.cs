using MongoDB.Driver;

namespace JwtAuth.Repository.Interfaces
{
    public interface IMongoDbContext
    {
        public IMongoClient MongoClient { get; }
        public IMongoDatabase MongoDatabase { get; }
    }
}
