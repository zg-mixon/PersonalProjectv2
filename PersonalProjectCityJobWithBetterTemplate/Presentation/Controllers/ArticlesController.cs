using PersonalProjectCityJobWithBetterTemplate.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PersonalProjectCityJobWithBetterTemplate.Presentation.Controllers
{
    public class ArticlesController : ApiController
    {

        private ArticleService _articleService;

        public ArticlesController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        public IList<ArticleDTO> Get() {
            return _articleService.GetArticles();
        }
    }
}
