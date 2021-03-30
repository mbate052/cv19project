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
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        /// private JsonUserReaderService Jsonservice;
        public UsersService DBservice;
        public IEnumerable<User> Users; 
        public AssessmentCenterService ACservice;
        public IEnumerable<AssessmentCenter> AssessmentCenters;
        
        public string Username { get; set; }
        public string Password { get; set; }
        private object jsonservice;

        public CreateModel(ILogger<CreateModel> logger, JsonUserReaderService jurs, UsersService uServ, AssessmentCenterService aServ) 
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
        public void OnPostSubmit(User newuser)
        {
            this.Username = newuser.Username;
            this.Password = newuser.Password;
            DBservice.Create(newuser);
    
        }
    }
}
