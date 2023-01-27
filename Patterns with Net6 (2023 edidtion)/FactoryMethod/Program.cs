using FactoryMethod;

Console.Title = "Factory Method";

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(),
    new CountryDiscountFactory()
};

foreach (var factory in factories) {
    var service = factory.CreateDiscountService();
    Console.WriteLine(service.DiscountPercentage);
}

Console.ReadLine();