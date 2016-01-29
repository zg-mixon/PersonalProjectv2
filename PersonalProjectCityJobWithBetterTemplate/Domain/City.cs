using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Domain.Identity
{
    public class City : IDbEntity, IActivatable
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PictureUrl { get; set; }

        IList<Job> Jobs { get; set; }

        IList<ApplicationUser> AU { get; set; }

        public bool Active { get; set; } = true;
    }
}