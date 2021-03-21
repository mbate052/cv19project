using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using covidwatch.Model;

namespace covidwatch.services
{
    public class JsonUserReaderService
    {
        public JsonUserReaderService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "users.json"); }
        }

        public IEnumerable<AssessmentCenter> GetAssessmentCenters()
        {
            using(var jsonFileReader = File.OpenText(Json))
            {
                return JsonSerializer.Deserialize<AssessmenCenter[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }
    }
}