using Syetem.Text.Json.Serialization;

namespace cv19project.Model 
{
    public class Provinces 
    {
        public string id {get;set}
        [JsonPropertyName("name")]

        public string name {get; set; }
    }
}