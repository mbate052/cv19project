using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace cv19project.Model {
    public class Province2 {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id {get;set;}
        [BsonElement("Name")]
        public string Name{get;set; }
        public decimal TaxRate {get;set;}
    }
}