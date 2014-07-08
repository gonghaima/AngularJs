In string typed view @model List<MvcWithAngularJs.Models.TestObj>

Model passed to Angular.js using @Html.Raw(Json.Encode())

 $scope.testObjs = @Html.Raw(Json.Encode(Model));
 
 
 
The $scope.update = function() {… that is the Angular.js method called by a button on the view with an Angular.js data property ng-click=”update()”.  JQuery’s $.post command cannot be used here, you need to use the Angular.js $http.post command. 
 
 
 $scope.update = function() {
            $http.post("@Url.Action("UpdateVwMdl", "Home")").success(function(data) {
                $scope.testObjs = data;
            }); 
        };