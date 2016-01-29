using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Domain
{
    public class Sector : IDbEntity, IActivatable
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Job> Jobs { get; set; }

        public IList<ApplicationUser> ApplicationUsers { get; set; }

        public bool Active { get; set; } = true;
    }
}