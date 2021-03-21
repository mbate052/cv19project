using covidwatch.Model;

namespace covidwatch.Services
{
    public class AssessmentCenterService{
        private readonly IMongoCollection<AssessmentCenter> _AssessmentCenter;

        public AssessmentCenterService(AssessmenCenterDBSetting settings){
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabace(settings.DatabaseName);
            _AssessmentCenter = database.GetCollection<AssessmentCenter>(settings.AssessmentCenterCollectionName);
        }

        public List<AssessmentCenter> Get()
        {
            return _AssessmentCenter.Find(assessment_center => true).ToList();
        }
        
        }

    }

