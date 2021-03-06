﻿// Generated by IcedCoffeeScript 108.0.9
(function() {
  'use strict';
  angular.module('pos', ['ngRoute']).config(function($routeProvider) {
    return $routeProvider.when('/', {
      templateUrl: 'views/home.html'
    }).when('/employee', {
      templateUrl: 'views/employee.html',
      controller: 'employeeCtrl'
    }).when('/product', {
      templateUrl: 'views/product.html',
      controller: 'productCtrl'
    }).otherwise({
      redirectTo: '/'
    });
  });

}).call(this);
