app.controller("addProduct",function($scope, ajax, $location){
  ajax.get(app_root + "api/Product/Types/All" ,
  function(response){
    $scope.departments = response.data;
  },
  function(err){

  });

    $scope.addProduct = function(s){
      ajax.post(app_root + "api/Product/Products/Add", s,
      function(resp){
        $location.path("/products");
      },
      function(err){

      });
    };

});
