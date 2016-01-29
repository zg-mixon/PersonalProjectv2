using PersonalProjectCityJobWithBetterTemplate.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PersonalProjectCityJobWithBetterTemplate.Domain.Identity;

namespace PersonalProjectCityJobWithBetterTemplate.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        IDbSet<City> Cities { get; set; }

        IDbSet<Job> Jobs { get; set; }

        IDbSet<Sector> Sectors { get; set; }

        IDbSet<Article> Articles { get; set; }

        IDbSet<CityJob> CityJob { get; set; }
    }
}