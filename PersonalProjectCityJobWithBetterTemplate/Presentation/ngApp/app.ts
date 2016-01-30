namespace PersonalProjectCityJobWithBetterTemplate {
    
    angular.module('PersonalProjectCityJobWithBetterTemplate', ['ngRoute']);
    //angular.module('PersonalProjectCityJobWithBetterTemplate', ['ui.bootstrap']);

    angular.module('PersonalProjectCityJobWithBetterTemplate').factory('authInterceptor',
        ($q: ng.IQService, $window: ng.IWindowService, $location: ng.ILocationService) => {
            return {
                request: (config) => {
                    config.headers = config.headers || {};
                    let token = $window.localStorage.getItem('token');
                    if (token) {
                        config.headers.Authorization = `Bearer ${token}`;
                    }
                    return config;
                },
                responseError: (response) => {
                    if (response.status === 401) {
                        $location.path('/login');
                    }
                    return response || $q.when(response);
                }
            };
        });

    angular.module('PersonalProjectCityJobWithBetterTemplate')
        .config(function ($routeProvider: ng.route.IRouteProvider, $httpProvider: ng.IHttpProvider) {

            $httpProvider.interceptors.push('authInterceptor');

            $routeProvider.when('/', {
                templateUrl: '/Presentation/ngApp/views/homeView.html',
                controller: PersonalProjectCityJobWithBetterTemplate.Controllers.HomeController,
                controllerAs: 'controller'
            })
            $routeProvider.when('/jobs', {
                templateUrl: '/Presentation/ngApp/views/jobListings.html',
                controller: PersonalProjectCityJobWithBetterTemplate.Controllers.jobListingsController,
                controllerAs: 'controller'
            })
            $routeProvider.when('/cities', {
                templateUrl: '/Presentation/ngApp/views/cityListings.html',
                controller: PersonalProjectCityJobWithBetterTemplate.Controllers.CityListingsController,
                controllerAs: 'controller'
            })
            $routeProvider.when('/register', {
                templateUrl: '/Presentation/ngApp/views/registration.html',
                controller: PersonalProjectCityJobWithBetterTemplate.Controllers.AuthController,
                controllerAs: 'controller'
            });
        });
}