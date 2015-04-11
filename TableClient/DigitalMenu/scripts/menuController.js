restauraterModule.controller('menuCtrl',
    function menuCtrl($scope) {
        $scope.menu = {
            name: "The Happy Bloater Restaurant",
            menuType: "Spring Menu",
            location: {
                city: "Maidstone",
                county: "Kent"
            },
            starters: [
                { name: "Soup du Jour", price: 2.99 },
                { name: "Scallops", price: 3.20 },
                { name: "Prawn Cocktail", price: 4.99 },
            ],
            mains: [
                { name: "Roast Belly Pork", price: 13.99 },
                { name: "Chicken Tagine", price: 14.50 },
                { name: "Lobster Thermadore", price: 17.50 },
            ],
            desserts: [
                { name: "New York Style Cheesecake", price: 4.50 },
                { name: "Eton Mess", price: 4.10 },
                { name: "Ice Cream", price: 2.99 },
                { name: "Cheese Platter", price: 4.99 }
            ],
            drinks: [
                { name: "House White", price: 7.95 },
                { name: "House Red", price: 7.95 },
                { name: "Still Water", price: 4.75 },
                { name: "Coke", price: 3.25 },
            ]
        }
    });