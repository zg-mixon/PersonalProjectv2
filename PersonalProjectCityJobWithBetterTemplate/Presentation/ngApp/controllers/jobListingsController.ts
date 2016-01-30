namespace PersonalProjectCityJobWithBetterTemplate.Controllers {

    export class jobListingsController {

        public jobs;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/jobs')
                .then((response) => {
                    this.jobs = response.data;
                });
        }
    }
}