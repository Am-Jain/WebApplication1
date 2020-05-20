(function () {
    'use strict';

    angular
        .module('app')
        .controller('Employeecontroller', Employeecontroller);

    Employeecontroller.$inject = ['$location'];

    function Employeecontroller($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'Employeecontroller';

        activate();

        function activate() { }
    }
})();
