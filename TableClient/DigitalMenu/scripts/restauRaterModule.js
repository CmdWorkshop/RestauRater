var restauraterModule = angular.module('restaurater', []);

restauraterModule.config(function ($httpProvider) {
    $httpProvider.defaults.useXDomain = true;
    delete $httpProvider.defaults.headers.common['X-Requested-With'];
})