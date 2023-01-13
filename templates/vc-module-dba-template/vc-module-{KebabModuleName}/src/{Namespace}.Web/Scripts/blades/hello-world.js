angular.module('{ModuleName}')
    .controller('{ModuleName}.helloWorldController', ['$scope', '{ModuleName}.webApi', function ($scope, api) {
        var blade = $scope.blade;
        blade.title = '{ModuleName}';

        blade.refresh = function () {
            api.get(function (data) {
                blade.title = '{ModuleName}.blades.hello-world.title';
                blade.data = data.result;
                blade.isLoading = false;
            });
        };

        blade.refresh();
    }]);
