var tictactoe = {};
tictactoe.currentMove="x";

//set our score to nothing
tictactoe.playerscore_x=0;
tictactoe.playerscore_o=0;
tictactoe.WINS = [7, 56, 448, 73, 146, 292, 273, 84];

tictactoe.scoreplayer=function(player,moveScore){
	console.log("Player: " + player + " scores: " + moveScore);
	if ("x"===player){
		tictactoe.playerscore_x+=moveScore;
		tictactoe.checkForWin(tictactoe.playerscore_x, "Player X");
	}else if ("o"===player){
		tictactoe.playerscore_o+=moveScore;
		tictactoe.checkForWin(tictactoe.playerscore_o, "Player O");
	}else{
		console.log("no player was passed in.");
	}
	console.log("Player X: " + tictactoe.playerscore_x + "/Player O: " + tictactoe.playerscore_o);
}
tictactoe.checkForWin=function (totalScore, playerName){
	 /* Check for winner
	 *     273                 84
	 *        \               /
	 *          1 |   2 |   4  = 7
	 *       -----+-----+-----
	 *          8 |  16 |  32  = 56
	 *       -----+-----+-----
	 *         64 | 128 | 256  = 448
	 *       =================
	 *         73   146   292
	 
     */
	for(var i=0;i<tictactoe.WINS.length;i++){
		if (tictactoe.WINS[i]==totalScore){
			$('#msgInfo').text(playerName + " Wins!!!");
			$('#msgInfo').show();
		}
	}
}


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
		   //get score for magic square calculation	
		   var moveScore = $(this).data("score");  
		
		   //mark cells
		   if("x"===tictactoe.currentMove){
			  $(this).addClass("x-clicked");
			  tictactoe.scoreplayer("x",moveScore);
			  tictactoe.currentMove="o";
		   }else{
			  $(this).addClass("o-clicked"); 
			  tictactoe.scoreplayer("o",moveScore);
			  tictactoe.currentMove="x";	
			}	
		});
	}
);
