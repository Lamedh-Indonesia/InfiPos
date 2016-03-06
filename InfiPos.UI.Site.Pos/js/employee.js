(function () {

    var pos = angular.module('pos', []);

    function employeeCtrl($scope, $http) {
        //$scope.employees = [
        //    { Code: "E01", Name: 'Makan' },
        //    { Code: "E02", Name: 'Minum' },
        //    { Code: "E03", Name: 'Tidur' },
        //];

        var url = "http://localhost:4414/api/employee";

        $http.get(url + '?page=0&size=10').success(function (data) {
            $scope.employees = data;
            $scope.currentEmployee = $scope.employees[0];
        });

        $scope.selectEmployee = function (employee) {
            $scope.currentEmployee = employee;
        }

        $scope.save = function () {
            $http.post(url, $scope.currentEmployee).success(
                function () {
                    alert("Sukses");
                });
        }

        $scope.create = function () {
            $http.get(url + '/0').success(function (data) {
                $scope.currentEmployee = data;
            });
        }
    }

    pos.controller("employeeCtrl", employeeCtrl);

})()
