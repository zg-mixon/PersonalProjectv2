namespace PersonalProjectCityJobWithBetterTemplate.Controllers {

    export class CityListingsController {

        public cities;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/cities')
                .then((response) => {
                    this.cities = response.data;
                });
        }
    }
}