restauraterModule.controller("menuCtrl",["$scope","$http",
    function menuCtrl($scope, $http) {
        $scope.fullmenu =
            $http.get('http://localhost:50942/api/menu/items')
            .success(function (results) {
                $scope.menu = results;
            })
            .error(function () {
                console.log('Error retrieving menu');
            });

        $scope.getStarters = 
            $http.get('http://localhost:50942/api/menu/items?category=starters')
            .success(function (results) {
                $scope.starters = results;
            })
            .error(function () {
                console.log('Error retrieving starter items');
            });

        $scope.getMains =
            $http.get('http://localhost:50942/api/menu/items?category=mains')
            .success(function (results) {
                $scope.mains = results;
            })
            .error(function () {
                console.log('Error retrieving main items');
            });

        $scope.getDesserts =
            $http.get('http://localhost:50942/api/menu/items?category=desserts')
            .success(function (results) {
                $scope.desserts = results;
            })
            .error(function () {
                console.log('Error retrieving dessert items');
            });

        $scope.getDrinks =
            $http.get('http://localhost:50942/api/menu/items?category=drinks')
            .success(function (results) {
                $scope.drinks = results;
            })
            .error(function () {
                console.log('Error retrieving drink items');
            });
    }
]);