namespace Facade;

// intent to provide a unified interface to a set of interfaces


/// <summary>
/// sub-system discount service
/// </summary>
public class CustomerDiscountService {
    public int CalculateDiscount() {
        return 10;
    }
}

/// <summary>
/// sub-system discount service
/// </summary>
public class DayOfWeekDiscountService {
    public int CalculateDiscount() {
        return 20;
    }
}

/// <summary>
/// Facade
/// </summary>
public class FacadeDiscountService {
    private readonly CustomerDiscountService _customerDiscountService = new();
    private readonly DayOfWeekDiscountService _dayOfWeekDiscountService = new();


    public int CalculateDiscount() {
        return _customerDiscountService.CalculateDiscount() * _dayOfWeekDiscountService.CalculateDiscount();
    }
}