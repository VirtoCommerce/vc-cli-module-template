angular.module('{Namespace}')
    .factory('{Namespace}.webApi', ['$resource', function ($resource) {
        return $resource('api/{KebabModuleName}');
    }]);
