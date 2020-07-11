using Mongo2Go;
using MongoDB.Driver;
using JwtAuth.Domain.Entities;
using JwtAuth.Repository.Mappings;
using JwtAuth.Repository.Interfaces;

namespace JwtAuth.Repository
{
    public class MongoDbContext : IMongoDbContext
    {
        public IMongoClient MongoClient { get; }
        public IMongoDatabase MongoDatabase { get; }

        private readonly MongoDbRunner _mongoDbRunner;

        public MongoDbContext()
        {
            _mongoDbRunner = MongoDbRunner.Start();

            MongoClient = new MongoClient(_mongoDbRunner.ConnectionString);
            MongoDatabase = MongoClient.GetDatabase("db");

            MongoClassMap.RegisterClasses();

            var asag = MongoDatabase.GetCollection<User>("users");

            asag.InsertOne(new User("admin", "admin@admin.com", "admin", "admin"));
        }
    }
}
