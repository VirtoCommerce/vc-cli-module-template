angular.module('{ModuleName}')
    .factory('{ModuleName}.webApi', ['$resource', function ($resource) {
        return $resource('api/{KebabModuleName}');
    }]);
