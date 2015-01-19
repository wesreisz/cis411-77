$(document).ready(
	function(){
		console.log("loading tictactoe");
		
		//use this event handler to change the background of the cell to the X or )
		$( ".cell" ).on( "click", function() {
		   $(this).addClass("x-clicked");   
		});
	}
);