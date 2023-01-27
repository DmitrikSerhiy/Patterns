using BuilderPattern;

Console.Title = "Builder";


var garage = new Garage();

var bmvBuilder = new BMWCarBuilder();
var mercedesBuilder = new MercedesCarBuilder();


garage.Construct(bmvBuilder);
Console.WriteLine(bmvBuilder.Car.ToString());

garage.Construct(mercedesBuilder);
Console.WriteLine(mercedesBuilder.Car.ToString());

Console.ReadLine();