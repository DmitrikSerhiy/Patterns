// ReSharper disable once CheckNamespace
namespace Adapter.Class; 


public class CityFromExternalSystem {
    public CityFromExternalSystem(string name, string nickname) {
        Name = name;
        Nickname = nickname;
    }

    public string Name { get; set; }
    public string Nickname { get; set; }
}


/// <summary>
/// Adaptee
/// </summary>
public class ExternalSystem {
    public CityFromExternalSystem GetCity() {
        return new CityFromExternalSystem("Kyiv", "Capital");
    }
}


public class City {
    public City(string fullName) {
        FullName = fullName;
    }

    public string FullName { get; set; }
}

/// <summary>
/// Target
/// </summary>
public interface ICityAdapter {
    City GetCity();
}


/// <summary>
/// Adapter
/// the only difference from object is here. Instead of composition, the inheritance is used
/// </summary>
public class CityAdapter : ExternalSystem, ICityAdapter {

    public City GetCity() {

        // call external system
        var cityFromExternalSystem = base.GetCity();

        // adapt the externalSystem (adaptee) to the City
        return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.Nickname}");
    }
}