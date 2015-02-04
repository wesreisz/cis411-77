var app = angular.module('todo',[]);
app.controller('TodoController', function(){
	this.title = "Angular Todo List";
	this.todoText = "";
});