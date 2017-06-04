var myProd = angular.module("myModule", [])
               .controller("Mycontroller", function ($scope)
               {
                   var ProductDetails = [
                       { ProductID: "1", ProdImage: "~/Content/vegetables.jpg", ProdDesc: "Fresh vegetables endowed with almost all of the nutritional principles that our body requires" },
                       { ProductID: "2", ProdImage: "~/Content/cans-beverages-19492376.jpg", ProdDesc: "Fresh vegetables endowed with almost all of the nutritional principles that our body requires" }
                   ];
                   $scope.Product = ProductDetails;
               });

