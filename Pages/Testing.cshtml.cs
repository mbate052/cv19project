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
        public TestingModel(ILogger<TestingModel> logger, JsonUserReaderService jurs, UsersService uServ) 
        {
            _logger = logger;
            /// Jsonservice = jurs;
            DBservice = uServ;
        }


        private readonly ILogger<TestingModel> _logger;
        public AssessmentCenterService ACservice;
        public IEnumberable<AssessmentCenter> AssessmentCenters;
        public TestingModel(ILogger<TestingModel> logger, JsonAessReaderService jars, AssessmentCenterService aServ)
        {
            _logger = logger;
            jsonservice = jars;
            ACservice = aService;

        }

        public void OnGet()
        {
            Users = DBservice.Get();
            AssessmentCenters = jsonservice.GetAssessmentCenters();
        }
    }
}
