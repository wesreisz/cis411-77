var app = angular.module('todo',[]);
app.controller('TodoController',function(){
	this.title='Todo List';
	this.textInput='';
	this.todos = ['wes','kim'];
	this.addItem = function(item){
		this.todos.push(item);
		this.textInput='';
	};
});