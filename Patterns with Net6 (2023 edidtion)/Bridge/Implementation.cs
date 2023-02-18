namespace Bridge;

// intent is to decouple the abstraction from it's implementation so the two can vary (change) independently
// meaning with this pattern it's possible to replace an implementation with another implementation without 
// modifying the abstraction

/// <summary>
/// Abstraction
/// </summary>
public abstract class Menu {
    public readonly ICoupon Coupon;
    public  Menu(ICoupon coupon) {
        Coupon = coupon;
    }
    
    public abstract int CalculatePrice();
}


/// <summary>
/// refined abstractions
/// </summary>
public class VegetarianMenu : Menu {
    public VegetarianMenu(ICoupon coupon) : base(coupon) {
    }

    public override int CalculatePrice() {
        return 20 - Coupon.CouponValue;
    }
}

public class NormalMenu : Menu {
    public NormalMenu(ICoupon coupon) : base(coupon) {
    }

    public override int CalculatePrice() {
        return 30 - Coupon.CouponValue;
    }
}




/// <summary>
/// Implementor
/// </summary>
public interface ICoupon {
    int CouponValue { get; }
}

/// <summary>
/// Concrete implementors
/// </summary>
public class NoCoupon : ICoupon {
    public int CouponValue { get; } = 0;
}

public class OneEuroCoupon : ICoupon {
    public int CouponValue { get; } = 1;
}

public class TwoEuroCoupon : ICoupon {
    public int CouponValue { get; } = 2;
}


