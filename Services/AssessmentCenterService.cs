using MongoDB.Driver;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using covidwatch.Model;

namespace covidwatch.Services
{

    public class AssessmentCenterService
    {
        private readonly IMongoCollection<AssessmentCenter> _assessmentCenters;
        public AssessmentCenterService(AssessmentCenterDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _assessmentCenters = database.GetCollection<AssessmentCenter>(settings.AssessmentCenterCollectionName);
        }

        public List<AssessmentCenter> Get()
        {
            return _assessmentCenters.Find(AssessmentCenter =>true).ToList();
        }
        public AssessmentCenter Get(string id)
        {
            return _assessmentCenters.Find<AssessmentCenter>(AssessmentCenter => AssessmentCenter.Id == id).FirstOrDefault();
        }
        public void Update(string id, AssessmentCenter assessmentCenterIn){
            _assessmentCenters.ReplaceOne(AssessmentCenter => AssessmentCenter.Id == id, assessmentCenterIn);
        }
        public void Remove(AssessmentCenter assessmentCenterIn) 
        {
        _assessmentCenters.DeleteOne(AssessmentCenter => AssessmentCenter.Id == assessmentCenterIn.Id);
        }
        public void Remove(string id) 
        {
        _assessmentCenters.DeleteOne(AssessmentCenter => AssessmentCenter.Id == id);
        }
    }
}