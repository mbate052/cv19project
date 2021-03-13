using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace covidwatch.Model {
    public class User {
        [BsonId][BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int UID {get; set;}
        public string Username {get; set;}
        public string Password { get; set; }
    }
}
