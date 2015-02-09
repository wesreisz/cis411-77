'use strict';
//game messages
Game.MESSAGE_CLICK = 'Click on a tile.';
Game.MESSAGE_ONE_MORE = 'Pick one more card.'
Game.MESSAGE_MISS = 'Try again.';
Game.MESSAGE_MATCH = 'Good job! Keep going.';
Game.MESSAGE_WON = 'You win!';

function Tile(title){
	this.tileTitle=title;
	this.flipped = false;
	this.flip = function(){
		this.flipped = !this.flipped;
	}
}
function Game(){
	var _TILENAMES = 
		['8-ball','baked-potato','dinosaur','kronos','rocket',
	     'that-guy','zeppelin','cards'];
	this.tileDeck = makeDeck(_TILENAMES).shuffle();
	this.message = Game.MESSAGE_CLICK;
	this.unmatchedPairs = _TILENAMES.length;
	this.turn = 0;
	this.flipTile = function(tile){
		if (tile.flipped){
			return;
		}
		tile.flip();
		if (!this.firstPick || this.secondPick) {

	      if (this.secondPick) {
	        this.firstPick.flip();
	        this.secondPick.flip();
	        this.firstPick = this.secondPick = undefined;
	      }

	      this.firstPick = tile;
	      this.message = Game.MESSAGE_ONE_MORE;

	    } else {
		  this.turn++;
	      if (this.firstPick.tileTitle === tile.tileTitle) {
	        this.unmatchedPairs--;
	        this.message = (this.unmatchedPairs > 0) ? Game.MESSAGE_MATCH : Game.MESSAGE_WON;
	        this.firstPick = this.secondPick = undefined;
	      } else {
	        this.secondPick = tile;
	        this.message = Game.MESSAGE_MISS;
	      }
	    }	
	};
}
function makeDeck(tileNames){
	var tiles = [];
	tileNames.forEach(function(tile){
		tiles.push(new Tile(tile));
		tiles.push(new Tile(tile));
	});
	return tiles;
};

