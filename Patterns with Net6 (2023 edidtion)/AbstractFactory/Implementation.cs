namespace AbstractFactory;

///
/// The intent is to provide an interface for creating families of related or
/// dependent objects without specifying their concrete classes
///
/// It basically the same as factory methods but more extended.
/// It should be used when system should be configured with one of multiple families of products.
/// When family of related product objects is designed to be used together.
///
/// Just like Factory method it isolates concrete classes. (avoiding tight coupling)
/// It's easy to add new product (new implementation) without breaking existing code


// abstract factory
public interface IShoppingCartPurchaseFactory {
    IDiscountService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}

// abstract product
public interface IDiscountService {
    int DiscountPercentage { get; }
}

// another abstract product
public interface IShippingCostsService {
    decimal ShippingCosts { get; }
}



// implementations of products
public class UkraineDiscountService : IDiscountService {
    public int DiscountPercentage => 40;
}

public class FranceDiscountService : IDiscountService {
    public int DiscountPercentage => 30;
}

public class UkraineShippingCostsService : IShippingCostsService {
    public decimal ShippingCosts => 12;
}

public class FranceShippingCostsService : IShippingCostsService {
    public decimal ShippingCosts => 5;
}


// implementations of factories

public class UkraineShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory {
    public IDiscountService CreateDiscountService() {
        return new UkraineDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService() {
        return new UkraineShippingCostsService();
    }
}
public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory {
    public IDiscountService CreateDiscountService() {
        return new FranceDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService() {
        return new FranceShippingCostsService();
    }
}



/// <summary>
/// Client class
/// </summary>
public class ShoppingCart {

    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;
    public ShoppingCart(IShoppingCartPurchaseFactory factory) {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();
    }

    public decimal CalculateCosts() {
        return _discountService.DiscountPercentage * _shippingCostsService.ShippingCosts;
    }
    
}

