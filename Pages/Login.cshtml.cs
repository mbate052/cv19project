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
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;
        public UsersService DBservice;
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginModel(ILogger<LoginModel> logger, UsersService uServ)
        {
            _logger = logger;
            DBservice = uServ;
        }

        public void OnGet()
        {
        }
        public void OnPostSubmit(User newuser)
        {
            this.Username = newuser.Username;
            this.Password = newuser.Password;
            DBservice.Create(newuser);

        }
    }
}
