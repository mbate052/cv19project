using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv19project.Model;
using cv19project.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace cv19project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        // Provinces read from a file

        private JsonProvinceReaderService jsonservice;
        public IEnumerable<Province> Provinces;

        //Provinces read from the database
        public ProvincesService MyProvincesService;

        public string RequestId { get; set; }



        public IndexModel(ILogger<ErrorModel> logger, JsonProvinceReaderService jprs, ProvincesService ProvService)
        {
            _logger = logger;
            jsonservice = jprs;
            MyProvincesService = ProvService;
        }

        public void OnGet()
        {
            Provinces = jsonservice.GetProvinces();
        }
    }
}
