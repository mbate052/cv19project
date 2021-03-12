using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covidwatch.Model;
using covidwatch.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace covidwatch.Pages
{
    public class TestingModel : PageModel
    {
        private readonly ILogger<TestingModel> _logger;
        private JsonUserReaderService service;
        public IEnumerable<User> Users;

        public TestingModel(ILogger<TestingModel> logger, JsonUserReaderService jurs) 
        {
            _logger = logger;
            service = jurs;
        }

        public void OnGet()
        {
            Users = service.GetUsers();
        }
    }
}
