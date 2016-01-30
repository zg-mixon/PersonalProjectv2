using PersonalProjectCityJobWithBetterTemplate.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Infrastructure
{
    public class JobRepository : GenericRepository<Job>
    {
        public JobRepository(DbContext db) : base(db) { }

        public IQueryable<Job> GetJobs()
        {
            return from j in Table
                   where j.Active
                   select j;
        }
    }
}