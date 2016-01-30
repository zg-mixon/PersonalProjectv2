using PersonalProjectCityJobWithBetterTemplate.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Services.Models
{
    public class CityService
    {
        private CityRepository _cityRepo;

        public CityService(CityRepository cityRepo)
        {
            _cityRepo = cityRepo;
        }

        public IList<CityDTO> GetCities()
        {
            var cities = _cityRepo.GetCities();

            return (from c in cities
                    select new CityDTO()
                    {
                        Name = c.Name,
                        Description = c.Description,
                        PictureUrl = c.PictureUrl
                    }).ToList();
        }

    }
}

