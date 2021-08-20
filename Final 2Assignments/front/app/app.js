var app = angular.module("myApp", ["ngRoute"]);
var app_root = "https://localhost:44328/";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/addProduct", {
        templateUrl : "views/pages/addProduct.html",
        controller: 'addProduct'
    })
    .when("/product_Type", {
        templateUrl : "views/pages/product_Type.html",
        controller: 'product_Type'
    })
    .when("/addProduct_Type", {
        templateUrl : "views/pages/addProduct_Type.html",
        controller: 'addProduct_Type'
    })
    .when("/farmerBuyerList", {
        templateUrl : "views/pages/farmerBuyerList.html",
        controller: 'farmerBuyerList'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
