using Facade;

Console.Title = "Facade";


var facade = new FacadeDiscountService();

Console.WriteLine(facade.CalculateDiscount()); // so facade is a unified discount service which call internally other discount services