using PersonalProjectCityJobWithBetterTemplate.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Domain
{
    public class Job : IDbEntity, IActivatable
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Sector> Sectors { get; set; }

        public string PictureUrl { get; set; }

        public decimal NationalSalary { get; set; }

        public IList<City> Cities { get; set; }

        public ApplicationUser AU { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; } = true;
    }
}