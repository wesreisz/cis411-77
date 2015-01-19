var tictactoe = {};
tictactoe.currentMove="";

$(document).ready(
	function(){
		console.log("loading tictactoe");
		
		//use this event handler to change the background of the cell to the X or O
		$( ".cell" ).on( "click", function() {
		   //check to see if already selected	
		   if($(this).hasClass("o-clicked") || $(this).hasClass("x-clicked")){
				//alert("");
				$('#msgInfo').text("Please select a different cell, this one has already been selected.");
				$('#msgInfo').show().delay(1500).fadeOut('slow');
				return;
		   }	
		  
		   //mark cells
		   if("x"===tictactoe.currentMove){
			  $(this).addClass("o-clicked");
			  tictactoe.currentMove="o";
		   }else if("o"===tictactoe.currentMove){
			  $(this).addClass("x-clicked"); 
			  tictactoe.currentMove="x";	
			}else{
		      $(this).addClass("x-clicked"); 
		      tictactoe.currentMove="x";	
		   }	
		});
	}
);
