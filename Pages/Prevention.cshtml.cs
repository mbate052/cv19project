using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace covidwatch.Pages
{
    public class PreventionModel : PageModel
    {
        private readonly ILogger<PreventionModel> _logger;

        public PreventionModel(ILogger<PreventionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
