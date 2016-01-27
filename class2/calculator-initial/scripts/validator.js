var validator = {};
validator.message = "";

validator.notEmpty = function(element, msg){
	if(element.value.length == 0){
	    console.log(msg);
 	    element.focus;
        element.style.background = "#e46c6d";
		validator.message = validator.message + msg + "\n";
    }else{
		element.style.background = "#ccc";
	}
};
validator.validEmail = function(element, msg){
	var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

    if (!filter.test(element.value)) {
	   console.log(msg);
       element.style.background = "#e46c6d";
       validator.message = validator.message + msg + '\n';
       element.focus;
    }else{
		element.style.background = "#ccc";
	}
};
validator.validUrl = function(element, msg){
	var filter = /[-a-zA-Z0-9@:%_\+.~#?&//=]{2,256}\.[a-z]{2,4}\b(\/[-a-zA-Z0-9@:%_\+.~#?&//=]*)?/gi;;

    if (!filter.test(element.value)) {
       validator.message = validator.message + msg + '\n';
       element.style.background = "#e46c6d";
       element.focus;
    }else{
		element.style.background = "#ccc";
	}
}
validator.doValidation = function(){
	if(validator.message.length<=0){
	   console.log("Validation was successful");
  	   return true;
    }else{
	   console.log("Validation was NOT successful");
	   alert(validator.message);
	   return false;
    }
};
