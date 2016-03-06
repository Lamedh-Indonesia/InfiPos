(function () {

    var pos = angular.module('pos', []);

    function employeeCtrl($scope, $http) {
        //$scope.employees = [
        //    { Code: "E01", Name: 'Makan' },
        //    { Code: "E02", Name: 'Minum' },
        //    { Code: "E03", Name: 'Tidur' },
        //];

        $http.get("http://localhost:4414/api/employee").success(function (data) {
            $scope.employees = data;
        });
    }

    pos.controller("employeeCtrl", employeeCtrl);

})()
