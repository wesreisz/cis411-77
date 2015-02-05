var app = angular.module('todo',[]);
app.controller('TodoController',function(){
	this.title='Todo List';
	this.textInput='';
	this.todos = ['wes','kim'];
	this.isControlsShown = false;
	this.addItem = function(item){
		this.todos.push(item);
		this.textInput='';
	};
	this.toggleControls = function(){
		if(!this.isControlsShown){
			this.isControlsShown = true;
		}else{
			this.isControlsShown = false;
		} 
	};
});