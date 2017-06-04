var myApp = angular.module("myApp", []);

myApp.controller("mycontroller", function ($scope, $http)
{  
    
    $scope.submit = function () {
        if ($scope.username && $scope.password) {

            $http({
                method: "GET",
                url: "http://localhost:56290/api/home"
                
            }).then(function mySuccess(response) {
                $scope.myWelcome = response.data;
                console.log($scope.myWelcome);
            }, function myError(response) {
                $scope.myWelcome = response.statusText;
                console.log($scope.myWelcome);
            });
        } else {

            alert("Invalid Login");
        }
    }
   
});


