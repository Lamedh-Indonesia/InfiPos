#angular.module('pos', ['ngRoute']).config(function ($routeProvider) {
#    $routeProvider.when('/', { templateUrl: 'views/home.html' })
#        .when('/employee', { templateUrl: 'views/employee.html', controller: 'employeeCtrl' })
#        .otherwise({ redirectTo: '/' });
#});
#

'use strict'

angular.module 'pos', [
    'ngRoute'
#    'ngResource'
#    'ui.bootstrap'
#    'ngSanitize'
#    'ui.select'
    # 'ngAnimate'
    # 'ngCookies'
    # 'ngTouch'
]
.config ($routeProvider) ->
    $routeProvider
        .when '/',
            templateUrl: 'views/home.html'
#        .when '/sale',
#            templateUrl: 'views/sale.html'
#            controller: 'saleCtrl'
        .when '/employee',
            templateUrl: 'views/employee.html'
            controller: 'employeeCtrl'
        .when '/product',
            templateUrl: 'views/product.html'
            controller: 'productCtrl'
        .otherwise
            redirectTo: '/'