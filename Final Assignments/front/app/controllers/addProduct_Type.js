app.controller("addProduct_Type",function($scope, ajax){
    $scope.addProduct_Type = function(){
      var d = {
        Id : 0,
        Title : $scope.Title
      };
      ajax.post(app_root + "api/Product/Types/Add", d,
      function(response){

      },
      function(err){

      });
    };

});
