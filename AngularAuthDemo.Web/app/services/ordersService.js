'use strict';
app.factory('ordersService', ['$http', function ($http) {

    var serviceBase = 'http://localhost:58038/';
    var ordersServiceFactory = {};

    var getOrders = function () {

        return $http.get(serviceBase + 'api/orders').then(function (results) {
            return results;
        });
    };

    ordersServiceFactory.getOrders = getOrders;

    return ordersServiceFactory;

}]);