<<<<<<< Updated upstream
using Syetem.Text.Json.Serialization;

namespace cv19project.Model 
{
    public class Provinces 
    {
        public string id {get;set}
        [JsonPropertyName("name")]

        public string name {get; set; }
=======
using System.Text.Json.Serialization;

namespace cv19project.Model 
{
    public class Province
    {
        public string Id {get;set;}
        [JsonPropertyName("name")]

        public string Name {get; set; }
>>>>>>> Stashed changes
    }
}