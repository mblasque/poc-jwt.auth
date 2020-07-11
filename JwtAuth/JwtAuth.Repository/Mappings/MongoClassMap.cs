using JwtAuth.Domain.Entities;
using MongoDB.Bson.Serialization;

namespace JwtAuth.Repository.Mappings
{
    public static class MongoClassMap
    {
        public static void RegisterClasses()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(User)))
                BsonClassMap.RegisterClassMap<User>(
                      cm =>
                      {
                          cm.AutoMap();
                      });

        }
    }
}
