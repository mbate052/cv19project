using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using covidwatch.Model;

namespace covidwatch.Services
{
    public class UsersService
    {
        private readonly IMongoCollection<User> _users;
        public UsersService(UserDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }
        public List<User> Get()
        {
            return _users.Find(user => true).ToList();
        }
    }
}