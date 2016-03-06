(function () {

    var todo = angular.module('todo', []);

    function todoCtrl($scope) {
        $scope.todos = [
            { done: true, name: 'Makan' },
            { done: false, name: 'Minum' },
            { done: false, name: 'Tidur' },
        ];

        $scope.add = function () {
            $scope.todos.push($scope.input);
            $scope.input = "";
        }

        $scope.remaining = function () {
            var count = 0;
            angular.forEach($scope.todos, function (todo) {
                count += todo.done ? 1 : 0;
            });
            return count;
        }
    }

    todo.controller("todoCtrl", todoCtrl);

})()
