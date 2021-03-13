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
        public User Get(string id)
        {
            return _users.Find<User>(user => user.Id ==
            id).FirstOrDefault();
        }
        public User Create(User user)
        {
        _users.InsertOne(user);
        return user;
        }
        public void Remove(User userIn) 
        {
        _users.DeleteOne(user => user.Id == userIn.Id);
        }
        public void Remove(string id) 
        {
        _users.DeleteOne(user => user.Id == id);
        }
    }
}