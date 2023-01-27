using AbstractFactory;

Console.Title = "Abstract Factory";


var ukraineFactory = new UkraineShoppingCartPurchaseFactory();
var shoppingCartForClientFromUkraine = new ShoppingCart(ukraineFactory);
var totalCostForUkraine = shoppingCartForClientFromUkraine.CalculateCosts();

var franceFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForClientFromFrance = new ShoppingCart(franceFactory);
var totalCostForFrance = shoppingCartForClientFromFrance.CalculateCosts();


Console.WriteLine(totalCostForUkraine);
Console.WriteLine(totalCostForFrance);

Console.ReadLine();