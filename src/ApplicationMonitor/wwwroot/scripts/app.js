var ApplicationMonitoring;
(function (ApplicationMonitoring) {
    var AppController = (function () {
        function AppController($scope, $http) {
            this.$scope = $scope;
            this.$http = $http;
            this.test = "SUCCESS";
            $scope.test = "SUCCESS";
            $scope.showBirthdate = this.showBirthdate; //() => alert($scope.birthday);
        }
        AppController.prototype.showBirthdate = function () {
            alert(this.birthday);
        };
        return AppController;
    }());
    ApplicationMonitoring.AppController = AppController;
})(ApplicationMonitoring || (ApplicationMonitoring = {}));
angular.module('monitor').controller('AppController', ['$scope', '$http', ApplicationMonitoring.AppController]);
//# sourceMappingURL=app.js.map