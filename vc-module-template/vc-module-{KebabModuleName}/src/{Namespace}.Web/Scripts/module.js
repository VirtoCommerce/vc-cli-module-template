// Call this to register your module to main application
var moduleName = '{ModuleName}';

if (AppDependencies !== undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName, [])
    .config(['$stateProvider',
        function ($stateProvider) {
            $stateProvider
                .state('workspace.{ModuleName}State', {
                    url: '/{ModuleName}',
                    templateUrl: '$(Platform)/Scripts/common/templates/home.tpl.html',
                    controller: [
                        'platformWebApp.bladeNavigationService',
                        function (bladeNavigationService) {
                            var newBlade = {
                                id: 'blade1',
                                controller: '{ModuleName}.helloWorldController',
                                template: 'Modules/$({Namespace})/Scripts/blades/hello-world.html',
                                isClosingDisabled: true,
                            };
                            bladeNavigationService.showBlade(newBlade);
                        }
                    ]
                });
        }
    ])
    .run(['platformWebApp.mainMenuService', '$state',
        function (mainMenuService, $state) {
            //Register module in main menu
            var menuItem = {
                path: 'browse/{ModuleName}',
                icon: 'fa fa-cube',
                title: '{ModuleName}',
                priority: 100,
                action: function () { $state.go('workspace.{ModuleName}State'); },
                permission: '{ModuleName}:access',
            };
            mainMenuService.addMenuItem(menuItem);
        }
    ]);
