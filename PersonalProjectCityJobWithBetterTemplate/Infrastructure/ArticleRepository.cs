using PersonalProjectCityJobWithBetterTemplate.Domain;
using PersonalProjectCityJobWithBetterTemplate.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Infrastructure
{
    public class ArticleRepository : GenericRepository<Article>
    {
        public ArticleRepository(DbContext db) : base(db) { }

        public IQueryable<Article> GetArticles() {
            return from a in Table
                   where a.Active
                   orderby a.CreatedDate descending
                   select a;
        }
    }
}
                   
                   