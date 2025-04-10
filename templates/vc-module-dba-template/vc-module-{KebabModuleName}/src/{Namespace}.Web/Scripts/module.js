// Call this to register your module to main application
var moduleName = '{Namespace}';

if (AppDependencies !== undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName, [])
    .config(['$stateProvider',
        function ($stateProvider) {
            $stateProvider
                .state('workspace.{ModuleName}State', {
                    url: '/{KebabModuleName}',
                    templateUrl: '$(Platform)/Scripts/common/templates/home.tpl.html',
                    controller: [
                        'platformWebApp.bladeNavigationService',
                        function (bladeNavigationService) {
                            var newBlade = {
                                id: 'blade1',
                                controller: '{Namespace}.helloWorldController',
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
                path: 'browse/{KebabModuleName}',
                icon: 'fa fa-cube',
                title: '{ModuleName}',
                priority: 100,
                action: function () { $state.go('workspace.{ModuleName}State'); },
                permission: '{KebabModuleName}:access',
            };
            mainMenuService.addMenuItem(menuItem);
        }
    ]);
