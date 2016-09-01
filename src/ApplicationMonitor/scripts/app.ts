namespace ApplicationMonitoring {


    export class AppController {

        test: string;
        birthday: string;
        constructor(private $scope, private $http) {
            this.test = "SUCCESS";
            $scope.test = "SUCCESS";
            $scope.showBirthdate = this.showBirthdate; //() => alert($scope.birthday);
        }

        showBirthdate () {
            alert(this.birthday);
        }

    }

}


angular.module('monitor').controller('AppController',
    ['$scope', '$http', ApplicationMonitoring.AppController]);
