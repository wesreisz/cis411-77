(function(){
	var app = angular.module('store',[]);
	app.controller('StoreController', function(){
		this.products = gems;
		
	})
	var gems=[ 
		{
			name: 'Dodechedron',
			price: 2.95,
			description: 'My bad a$$ gem',
			canPurchase: false,
			soldOut: false
		},
		{
			name: 'Pentagonal Gem',
			price: 5.95,
			description: 'My weak a$$ gem',
			canPurchase: false,
			soldOut: false
		},
		{
			name: 'Blue Cool Gem',
			price: 4.95,
			description: 'Kewl Gem',
			canPurchase: false,
			soldOut: false
		}
	];
})();

/*
Concepts:
 - Directives: HTML Annotations that trigger Javascript behaviors.
 - Modules: Where out application components lives.
 - Controller: Where we add application behavior.
 - Expressions: How values get displayed within the page.
*/