using PersonalProjectCityJobWithBetterTemplate.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProjectCityJobWithBetterTemplate.Services
{
    public class JobService
    {

        private JobRepository _jobRepo;

        public JobService(JobRepository jobRepo)
        {
            _jobRepo = jobRepo;
        }

        public IList<JobDTO> GetJobs()
        {
            var jobs = _jobRepo.GetJobs();

            return (from j in jobs
                    select new JobDTO()
                    {
                        Name = j.Name,
                        Description = j.Description,
                        PictureUrl = j.PictureUrl
                    }).ToList();


        }
    }
}