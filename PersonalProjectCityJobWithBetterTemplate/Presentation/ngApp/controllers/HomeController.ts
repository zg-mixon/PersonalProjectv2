namespace PersonalProjectCityJobWithBetterTemplate.Controllers {

    export class HomeController {

        public articles;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/articles')
                .then((response) => {
                    this.articles = response.data;
                });
        }
    }
    angular.module('PersonalProjectCityJobWithBetterTemplate').controller('authController', AuthController);
}
       
    