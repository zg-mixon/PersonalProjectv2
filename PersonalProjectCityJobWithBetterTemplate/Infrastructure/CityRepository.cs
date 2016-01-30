using PersonalProjectCityJobWithBetterTemplate.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Infrastructure
{
    public class CityRepository : GenericRepository<City>
    {
        public CityRepository(DbContext db) : base(db) { }

        public IQueryable<City> GetCities()
        {
            return from c in Table
                   where c.Active
                   select c;
        }

    }
}