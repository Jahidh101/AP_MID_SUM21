app.controller("product_Type",function($scope,ajax){
    function success(response){
      $scope.product_Type=response.data;
    }
    function error(error){

    }
    ajax.get(app_root + "api/Product/Types/All",success,error);

});
