using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covidwatch.Model;
using covidwatch.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace covidwatch.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        public UsersService DBservice;
        public string Username { get; set; }
        public string Password { get; set; }
        public int UID { get; set; }

        public CreateModel(ILogger<CreateModel> logger, UsersService uServ)
        {
            _logger = logger;
            DBservice = uServ;
        }
        public void OnPostSubmit(User newuser)
        {
            this.Username = newuser.Username;
            this.Password = newuser.Password;
            this.UID = newuser.UID;
            DBservice.Create(newuser);
    
        }
    }
}
