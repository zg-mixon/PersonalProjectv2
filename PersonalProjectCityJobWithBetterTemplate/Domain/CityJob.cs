using PersonalProjectCityJobWithBetterTemplate.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Domain
{
    public class CityJob : IDbEntity, IActivatable
    {

        public int Id { get; set; }

        public IList<City> Cities { get; set; }

        public IList<Job> Jobs { get; set; }

        public decimal Salary { get; set; }

        public bool Active { get; set; } = true;


    }
}