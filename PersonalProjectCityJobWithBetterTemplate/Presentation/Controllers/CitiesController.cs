using PersonalProjectCityJobWithBetterTemplate.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PersonalProjectCityJobWithBetterTemplate.Presentation.Controllers
{
    public class CitiesController : ApiController
    {

        private CityService _cityService;

        public CitiesController(CityService cityService)
        {
            _cityService = cityService;
        }

        public IList<CityDTO> Get()
        {
            return _cityService.GetCities();
        }
    }
}
