namespace FactoryMethod;

/// <summary>
/// Factory method is very suitable when you don't know which implementation of
/// the service you might need. Or when you need all of them but don't know
/// how many of them are actually exists.
///
/// Factory method separates concrete implementations from it's interfaces.
/// By using only creator it's possible to call any class you need without knowing
/// implementation details (avoiding type coupling)
/// 
/// patters often use together with IOC containers (registering a list of IBase interfaces
/// and then resolved as list of implementations)
/// </summary>

// base class
// if you need to provide some basic functionality that can be overridden then use abstract class
// use interface when you need to specify the expected functionality of a class
public abstract class DiscountService { // OR IT MIGHT BE AN INTERFACE
    public abstract int DiscountPercentage { get; }
    public override string ToString() {
        return GetType().Name;
    }
}


// first implementation
public class CountryDiscountService : DiscountService {
    public override int DiscountPercentage => 10;
}


// second implementation
public class CodeDiscountService : DiscountService {
    public override int DiscountPercentage => 15;
}


// base creator
public abstract class DiscountFactory {
    public abstract DiscountService CreateDiscountService();
}

// creator for first implementation
public class CountryDiscountFactory : DiscountFactory {
    public override DiscountService CreateDiscountService() {
        return new CountryDiscountService();
    }
}

// creator for second implementation
public class CodeDiscountFactory : DiscountFactory {
    public override DiscountService CreateDiscountService() {
        return new CodeDiscountService();
    }
}