using PersonalProjectCityJobWithBetterTemplate.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PersonalProjectCityJobWithBetterTemplate.Presentation.Controllers
{
    public class JobsController : ApiController
    {

        private JobService _jobService;

        public JobsController(JobService jobService)
        {
            _jobService = jobService;
        }

        public IList<JobDTO> Get()
        {
            return _jobService.GetJobs();
        }
    }
}