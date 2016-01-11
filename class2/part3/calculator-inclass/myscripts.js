function addToField(val){
	console.log("appending: " + val);
	var data = document.getElementById('calculator-display');
	data.innerHTML=data.innerHTML + val;
}
function calculate(){
	var data = document.getElementById('calculator-display');
	console.log("evaluating: " + data.innerHTML + " to " + eval(data.innerHTML));
	data.innerHTML=eval(data.innerHTML);
}
function clr(){
	console.log("clearing");
	var data = document.getElementById('calculator-display');
	data.innerHTML=' ';
}

document.onkeypress = function(evt) {
    evt = evt || window.event;
    var charCode = evt.keyCode || evt.which;
    var charStr = String.fromCharCode(charCode);
    if(charStr=='='){
    	calculate();
    }else{
	    var data = document.getElementById('calculator-display');
		data.innerHTML=data.innerHTML+charStr;	
    }
};