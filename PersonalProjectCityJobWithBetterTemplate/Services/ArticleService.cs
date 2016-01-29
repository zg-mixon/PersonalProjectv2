using PersonalProjectCityJobWithBetterTemplate.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Services
{
    public class ArticleService
    {

        private ArticleRepository _articleRepo;

        public ArticleService(ArticleRepository articleRepo)
        {
            _articleRepo = articleRepo;
        }

        public IList<ArticleDTO> GetArticles()
        {

            var articles = _articleRepo.GetArticles();

            return (from a in articles
                    select new ArticleDTO()
                    {
                        Title = a.Title,
                        Content = a.Content,
                        CreatedDate = a.CreatedDate
                    }).ToList();
        }

    }
}