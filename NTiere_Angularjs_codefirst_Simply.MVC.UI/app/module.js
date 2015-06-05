
//Root Controller
window.app = angular.module('personApp', ['ngRoute', 'ngResource', 'ngCookies']);
app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
    .when('/demo', { templateUrl: '/home/demo', controller: 'DemoController' })
        .when('/profile', { templateUrl: '/home/profile', controller: 'ProfileController' })
    .otherwise({ redirectTo: '/demo' });
}])
.controller('RootController', ['$scope', '$route', '$routeParams', '$location', function ($scope, $route, $routeParams, $location) {
    $scope.$on('$routeChangeSuccess', function (e, current, previous) {
        $scope.activeViewPath = $location.path();

    });
}]);

app.controller('RootController', function ($scope) {
   
});
app.controller('ProfileController', function ($scope) {
    
});
app.controller('DemoController', function ($scope, dataService) {
     $scope.persons = [];
    loadRecords();


    function loadRecords() {
        var personsdata = dataService.get();
        personsdata.then(function (pdata) {
            $scope.persons = pdata.data;
        },
        function (error) {
            alert('error');
        });
    };
    $scope.delete = function (data) {
        if (confirm('Are you Sure?')) {
            var deletePerson = dataService.delete(data);
            deletePerson.then(function (pd) {
                loadRecords();
                alert('Data Deleted Successfully');
            }, function (error) {
                alert('An error Occured');
            });
        }
    };
    $scope.select = function (data) {
        $scope.person = data;
    };
    $scope.save = function () {
        var saveData = $scope.person;
        if (saveData.ID > 0) {
            var updatePerson = dataService.put(saveData);
            updatePerson.then(function (prmData) {
                alert('Data updated');
            }, function (error) {
                alert('An error occured');
            });
        }
        else {
            var savePerson = dataService.post(saveData);
            savePerson.then(function (pdata) {
            }, function (error) {
            });
            clearText();
        }
    };
    $scope.clear =function()
    {
        clearText();
    }
        function clearText() {
        var newPerson = {};
        newPerson.ID = 0;
        newPerson.Name = "";
        newPerson.Age = "";
        newPerson.DOB = "";
        newPerson.Cell = "";
        newPerson.Email = "";
        $scope.person = newPerson;

    }
});
angular.module('personApp').service('dataService',['$http', function ($http) {
    var baseUrl = "/api/person/";
    this.post=function(person)
    {
        var request = $http({
            method: 'post',
            url: baseUrl,
            data:person
        });
    }
    this.put = function (person) {
        var request = $http({
            method: 'put',
            url: baseUrl,
            data:person
        });
    }
    this.delete = function (person) {
        var request = $http({
            method: 'delete',
            url:baseUrl+person.ID
        });
        return request;
    }
    this.get=function()
    {
       return $http.get(baseUrl);
    }
}]);