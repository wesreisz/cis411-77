'use strict';
var app = angular.module("game", ['ngRoute', 'ngAnimate']);
app.config(function($routeProvider){
   $routeProvider
    	.when('/',{
		    templateUrl: 'templates/home.htm'
	    })
		.when('/play',{
	         templateUrl: 'templates/game.htm',
		    controller:  'GameCntl'
	    })
	    .when('/about',{
	         templateUrl: 'templates/about.htm'
	    }) 
		.otherwise({
		     redirectTo: '/'
	    })
});

app.controller('cfgController',function($scope){
});
