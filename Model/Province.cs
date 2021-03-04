using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace cv19project.Model {
    public class Province {
        [BsonId]
        public string id{get;set;}
        [JsonPropertyName("name")]
        public string name{get;set; }
    }
}
