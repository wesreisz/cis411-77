/*
 * Purpose: Develop a Tic Tac Toe game using jQuery.
 * Author: Wesley Reisz, wes@wesleyreisz.com
 * Defects: 
 * 
 * Presentation Material: http://www.slideshare.net/dbert721/intro-to-jquery-2011
 * Example: http://www.mkyong.com/jquery/jquery-fadein-fadeout-and-fadeto-example/
 * Best Practices: http://www.learn-jquery-tutorial.com/BestPractices.cfm#.UFf2_6Tybvg
 * Complicated Maybe: http://www.bulgaria-web-developers.com/projects/javascript/jttt/
 *         http://www.webdevplayground.com/demos/tic_tac_toe/tic_tac_toe.js
 * book game math: Five golden rules : great theories of 20th-century mathematics and why they matter
 * AI Tree: http://en.wikipedia.org/wiki/Minimax         
 * 
 *
 *     273                 84
 *        \               /
 *          1 |   2 |   4  = 7
 *       -----+-----+-----
 *          8 |  16 |  32  = 56
 *       -----+-----+-----
 *         64 | 128 | 256  = 448
 *       =================
 *         73   146   292
 *
 * Extra Credit:  Magic Square Solution: http://mathworld.wolfram.com/MagicSquare.html
 */
var game ={};
game.count = 0;
game.player = "O";
game.winsCombinations = 
	["1,2,3", "4,5,6", "7,8,9", "1,4,7", "2,5,8", "3,6,9", "1,5,9", "3,5,7"];

game.playerOMoves = [0,0,0,0,0,0,0,0,0];
game.playerXMoves = [0,0,0,0,0,0,0,0,0];
game.wins = [7, 56, 448, 73, 146, 292, 273, 84];

game.setPlayer = function(val){
	game.player = val;
};
game.incrementCount = function(val){
	game.count += 1;
	if (game.count%2==0){
		game.player = "O";
	}else{
		game.player = "X";
	}
};
game.move = function(cell){
	var pos = parseInt(game.getIndex(cell.attr('id'))-1);//game tile # selected]
	
	if (game.player=="O"){
		cell.css("background","url(images/tic-tac-toe-O.png)");	
		game.playerOMoves[pos]=game.power(2,pos);
	}else{
		cell.css("background","url(images/tic-tac-toe-X.png)");	
		game.playerXMoves[pos]=game.power(2,pos);
	}
};
game.score = function(){
	for(var i=0;i<game.winsCombinations.length;i++){
		var score = {o:0,x:0};
		var combos = game.winsCombinations[i].split(',');//1,2,3
		
		//score for O
		for(var y=0;y<combos.length;y++){
			//console.log(" combo:: " + combos[y] + " / " + game.playerOMoves[parseInt(combos[y])-1]);
			score.o += parseInt(game.playerOMoves[parseInt(combos[y])-1]);
		}
		//score for X
		for(var z=0;z<combos.length;z++){
			//console.log(" combo:: " + combos[z] + " / " + game.playerOMoves[parseInt(combos[z])-1]);
			score.x += parseInt(game.playerXMoves[parseInt(combos[z])-1]);
		}
	
		//evaluate x & y against wins
		for(var cnt=0;cnt<game.wins.length;cnt++){	
			if (game.wins[cnt]==score.o){
				$("#dialog").html("O Wins!").dialog();
			}else if(game.wins[cnt]==score.x){
				$("#dialog").html("X Wins!").dialog();
			}else if(game.count>=9){
				$("#dialog").html("Draw!").dialog();
			}
		}
	};
};
game.hasNotMoved = function(cell){
	console.log(cell.css("background").length);
	if (cell.css("background").length<=71){ return true;}
	else {return false;}
};
game.power = function(base, exponent){
	if (exponent == 0){ 
		return 1; 
	}else{
		return base * game.power(base, exponent - 1);
	}
};
game.getIndex = function(cell){
	return cell.replace("cell","");
};