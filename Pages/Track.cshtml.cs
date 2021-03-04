using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace covidwatch.Pages
{
    public class TrackModel : PageModel
    {
        private readonly ILogger<TrackModel> _logger;

        public TrackModel(ILogger<TrackModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
