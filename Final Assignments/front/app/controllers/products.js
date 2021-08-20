app.controller("products",function($scope,$http,ajax){
    ajax.get(app_root + "api/Product/All/Details",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

});
