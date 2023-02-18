using Bridge;

Console.Title = "Bridge";
// so pattern allows to create as many coupons and menus without changing the abstraction

ICoupon noCoupon = new NoCoupon();
ICoupon oneCoupon = new OneEuroCoupon();
ICoupon twoCoupon = new TwoEuroCoupon();


Menu vMenuWithoutCoupon = new VegetarianMenu(noCoupon);
Menu vMenuWithOneCoupon = new VegetarianMenu(oneCoupon);
Menu vMenuWithTwoCoupon = new VegetarianMenu(twoCoupon);


Menu menuWithoutCoupon = new NormalMenu(noCoupon);
Menu menuWithOneCoupon = new NormalMenu(oneCoupon);
Menu menuWithTwoCoupon = new NormalMenu(twoCoupon);


Console.WriteLine(vMenuWithoutCoupon.CalculatePrice());
Console.WriteLine(vMenuWithOneCoupon.CalculatePrice());
Console.WriteLine(vMenuWithTwoCoupon.CalculatePrice());

Console.WriteLine(menuWithoutCoupon.CalculatePrice());
Console.WriteLine(menuWithOneCoupon.CalculatePrice());
Console.WriteLine(menuWithTwoCoupon.CalculatePrice());




