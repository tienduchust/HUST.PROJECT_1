app.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', 'constants', function ($stateProvider, $urlRouterProvider, $locationProvider, constants) {

    $urlRouterProvider.rule(function ($i, $location) {
        var path = $location.path();
        var normalized = path.toLowerCase();
        if (path !== normalized) return normalized;
    });

   

    $locationProvider.html5Mode(true).hashPrefix('!');
}]);