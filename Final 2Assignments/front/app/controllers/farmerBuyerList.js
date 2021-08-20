app.controller("farmerBuyerList",function($scope,$http,ajax){
    ajax.get(app_root + "api/Product/farmerBuyerList",success,error);
    function success(response){
      $scope.farmerBuyerList=response.data;
    }
    function error(error){

    }

});
