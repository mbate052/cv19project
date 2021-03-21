using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

       
namespace covidwatch.Model {
    public class AssessmentCenter {
        [BsonId][BsonRepresentation(BsonType.ObjectId)]

        public string Id{get;set;}
        
        public string phone{get;set;}
        public string city{get;set; }
        public string location_name{get;set;}
        public string address{get;set; }
    }
}