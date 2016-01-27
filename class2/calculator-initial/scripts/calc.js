// JavaScript Document
var calc = {};
calc.post = function(val){
	var originalVal = document.getElementById("result").innerHTML;
	var newVal = originalVal + val;
	document.getElementById("result").innerHTML = newVal;
}
calc.clear = function(){
	document.getElementById("result").innerHTML = "";
}
calc.calculate = function(){
	var originalVal = document.getElementById("result").innerHTML;
	document.getElementById("result").innerHTML = eval(originalVal);
}
calc.invert = function(){
	var originalVal = document.getElementById("result").innerHTML;
	document.getElementById("result").innerHTML = "-(" + originalVal + ")";
}
calc.convert2percent = function(){
	var originalVal = document.getElementById("result").innerHTML;
	document.getElementById("result").innerHTML = eval(originalVal)/100;
}

function sayHello(myNewVal){
	document.getElementById("result").innerHTML = myNewVal;
}

function validateForm(){
	var email = document.getElementById("txtEmail");
	var feedback = document.getElementById("txtFeedback");
	var emailRegEx = /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$/i;
	var formComplete = true;
	
	if (email.value.length<=0 || email.value=="Please enter a value for email."){
		email.style.background = "#e46c6d";
		email.value = "Please enter a value for email.";
		formComplete = false;
	}else  if (email.value.search(emailRegEx) == -1) {
		email.style.background = "#CC6699";
		document.getElementById("divMsg").style.background = "#e46c6d";
		document.getElementById("divMsg").style="display:inline;"
		document.getElementById("divMsg").innerHTML = "Please enter a valid email address.";
	}else{
		email.style.background = "#CCCCCC";
	
	}
	
	if (feedback.value.length<=0 || feedback.value=="Please enter feedback before submitting."){
		feedback.style.background = "#e46c6d";
		feedback.value = "Please enter feedback before submitting.";
		formComplete = false;
	}else{
		feedback.style.background = "#CCCCCC";
	}
	
	if (formComplete){
		document.getElementById("divMsg").style.background = "#e46c6d";
		document.getElementById("divMsg").style="display:inline;"
		document.getElementById("divMsg").innerHTML="Form Submitted... Thank you";
	}
}