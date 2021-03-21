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
            var client2 = new MongoClient(settings.ConnectionString);
            var database2 = client2.GetDatabase(settings.DatabaseName);
            _assessmentCenters = database2.GetCollection<AssessmentCenter>(settings.AssessmentCenterCollectionName);
        }

        public AssessmentCenter Create(AssessmentCenter assessmentCenter)
        {   _assessmentCenters.InsertOne(assessmentCenter);
            return assessmentCenter;
        }
        
        public List<AssessmentCenter> Get()
        {
            return _assessmentCenters.Find(assessmentCenter => true).ToList();
        }
        
        public AssessmentCenter Get(string id)
        {
            return _assessmentCenters.Find<AssessmentCenter>(assessmentCenter => assessmentCenter.Id == id).FirstOrDefault();
        }
        public void Update(string id, AssessmentCenter assessmentCenterIn){
            _assessmentCenters.ReplaceOne(assessmentCenter => assessmentCenter.Id == id, assessmentCenterIn);
        }
        public void Remove(AssessmentCenter assessmentCenterIn) 
        {
        _assessmentCenters.DeleteOne(assessmentCenter => assessmentCenter.Id == assessmentCenterIn.Id);
        }
        public void Remove(string id) 
        {
        _assessmentCenters.DeleteOne(assessmentCenter => assessmentCenter.Id == id);
        }
    }
}