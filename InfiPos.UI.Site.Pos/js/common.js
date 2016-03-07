function extendScope(scope, http, entityName) {
    var url = "http://localhost:4414/api/" + entityName;

    http.get(url + '?page=0&size=10').success(function (data) {
        scope.entities = data;
        scope.currentEntity = scope.entities[0];
    });

    scope.selectEntity = function (entity) {
        scope.currentEntity = entity;
    };

    scope.save = function () {
        http.post(url, scope.currentEntity).success(function () {
            alert("Success");
        });
    };

    scope.create = function () {
        http.get(url + '/0').success(function (data) {
            scope.currentEntity = data;
        });
    };
};
