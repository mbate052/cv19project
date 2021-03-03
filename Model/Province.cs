using System.Text.Json.Serialization;

namespace cv19project.Model {
    public class Province {

        public string Id{get;set;}
        [JsonPropertyName("name")]
        public string Name{get;set; }
    }
}
