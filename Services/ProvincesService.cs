using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using cv19project.Model;
namespace cv19project.services
{
    public class ProvincesService 
    {
        private readonly IMongoCollection<Province> _provinces;
        public ProvincesService(ProvinceDatabaseSettings settings) 
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _provinces = database.GetCollection<Province>(settings.ProvincesCollectionName);
        }
        public List<Province> Get() {
            return _provinces.Find(province => true).ToList();
        }

    } 
}
