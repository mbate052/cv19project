using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covidwatch.Model;
using covidwatch.services;
using covidwatch.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace covidwatch.Pages
{
    public class TestingModel : PageModel
    {
        private readonly ILogger<TestingModel> _logger;
        /// private JsonUserReaderService Jsonservice;
        public UsersService DBservice;
        public IEnumerable<User> Users;
        public AssessmentCenterService ACservice;
        public IEnumerable<AssessmentCenter> AssessmentCenters;
        private JsonAssReaderService jsonService2;
        private object jsonservice;

        public TestingModel(ILogger<TestingModel> logger, JsonUserReaderService jurs, UsersService uServ, AssessmentCenterService aServ) 
        {
            _logger = logger;
            jsonservice = jurs;
            DBservice = uServ;
            ACservice = aServ;
        }
        public void OnGet()
        {
            Users = DBservice.Get();
            AssessmentCenters = ACservice.Get();
        }
 
        
    }
}
