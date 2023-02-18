using Adapter;
using Adapter.Object;

Console.Title = "Adapter";

Adapter.Object.ICityAdapter adapter1 = new Adapter.Object.CityAdapter();
var city1 = adapter1.GetCity();

Console.WriteLine(city1.FullName);


Adapter.Class.ICityAdapter adapter2 = new Adapter.Class.CityAdapter();
var city2 = adapter2.GetCity();

Console.WriteLine(city2.FullName);
Console.ReadLine();