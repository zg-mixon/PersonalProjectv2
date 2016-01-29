using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Domain
{
        public class Article : IDbEntity, IActivatable
        {
            public int Id { get; set; }

            public string Title { get; set; }

            public string Content { get; set; }

            public DateTime CreatedDate { get; set; } = DateTime.Now;

            public bool Active { get; set; } = true;
        }
    }
