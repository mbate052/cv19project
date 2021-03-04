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
    public class TestModel : PageModel
    {
        private readonly ILogger<TestModel> _logger;
        // Provinces read from a file

        private JsonProvinceReaderService jsonservice;
        public IEnumerable<Province> Provinces;

        //Provinces read from the database
        public ProvincesService MyProvincesService;

        public string RequestId { get; set; }



        public TestModel(ILogger<ErrorModel> logger, JsonProvinceReaderService jprs, ProvincesService ProvService)
        {
            _logger = (ILogger<TestModel>)logger;
            jsonservice = jprs;
            MyProvincesService = ProvService;
        }

        public void OnGet()
        {
            Provinces = jsonservice.GetProvinces();

        }
    }
}
