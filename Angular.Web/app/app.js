

var app = angular.module('app', ['authenticationModule', 'ngRoute']);

app.config([
    '$routeProvider', '$locationProvider', function($routeProvider,$locationProvider) {

       $locationProvider.html5Mode(false);

        $routeProvider
            .when('/home', { templateUrl: "app/authentication/authenticationView.html" })

        .otherwise({redirectTo: '/home'});

    }
]);

app.controller('rootController', function($rootScope) {

    $rootScope.name = "Bilal";


});
