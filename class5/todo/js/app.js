var app = angular.module('todo',[]);
app.controller('TodoController', function(){
	this.title = "Angular Todo List";
	this.todoText = "";
	this.todos = [];
	this.addTodo = function(todoItem){
		this.todos.push(todoItem);
		this.todoText = "";
	};
});