var app = angular.module('todo',[]);
app.controller('TodoController', ['$scope',function($scope){
	this.title = "Angular Todo List";
	this.todoText = "";
	this.todos = [];
	this.showDelete = false;
	//adding method
	this.addTodo = function(todoItem){
		if(todoItem.length>0){
			this.todos.push(todoItem);
			this.todoText = "";
		}
	};
	//editing method
	this.toogleEdit = function(todoItem){
		this.todoText = todoItem;
		this.deleteItem(todoItem);
	}
	//toogle delete action
    this.toogleDelete = function(todoItem){
		if(!this.showDelete){
			this.showDelete = true;
		}else{
			this.showDelete = false;
		}
	}
	//deleting method
	this.deleteItem = function(todoItem){
		var pos = this.todos.indexOf(todoItem);
		if (pos > -1) {
		    this.todos.splice(pos, 1);
		}
	}
}]);

