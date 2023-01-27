using System.Text;

namespace BuilderPattern;

/// Intent to separate the construction of complex object from it's representation.
/// it allows create complex object independent of the parts that make up the object

// product
public class Car {
    private string _brand;
    public List<string> _parts;

    public Car(string brand) {
        _brand = brand;
        _parts = new List<string>();
    }

    public void AddPart(string part) {
        _parts.Add(part);
    }

    public override string ToString() {
        var sb = new StringBuilder();
        foreach (var part in _parts) {
            sb.Append($"Car of brand {_brand} has part {part}");
            sb.AppendLine("");
        }

        sb.AppendLine("");
        return sb.ToString();
    }
}


// builder
public abstract class CarBuilder {
    public Car Car { get; private set; }

    public CarBuilder(string carBrand) {
        Car = new Car(carBrand);
    }

    public abstract void BuildEngine();
    public abstract void BuildFrame();
}


// concrete builder
public class BMWCarBuilder : CarBuilder {
    public BMWCarBuilder() : base("BMW") { }

    public override void BuildEngine() {
        Car.AddPart("new powerful BMW engine");
    }

    public override void BuildFrame() {
        Car.AddPart("shining BMW frame");
    }
}

public class MercedesCarBuilder : CarBuilder {
    public MercedesCarBuilder() : base("Mercedes") { }

    public override void BuildEngine() {
        Car.AddPart("used medium Mercedes engine");
    }

    public override void BuildFrame() {
        Car.AddPart("common Mercedes frame");
    }
}



// Director
public class Garage {
    private CarBuilder? _carBuilder;

    public Garage() {}

    public void Construct(CarBuilder builder) {
        _carBuilder = builder;
        
        _carBuilder.BuildEngine();
        _carBuilder.BuildFrame();
    }
}
