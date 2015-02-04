var app = angular.module('todo',[]);
app.controller('TodoController', function(){
	this.title = "Angular Todo List";
	this.todoText = "";
	this.todos = [];
	//adding method
	this.addTodo = function(todoItem){
		this.todos.push(todoItem);
		this.todoText = "";
	};
	//editing method
	this.toogleEdit = function(todoItem){
		this.todoText = todoItem;
		var pos = this.todos.indexOf(todoItem);
		if (pos > -1) {
		    this.todos.splice(pos, 1);
		}

	}
});