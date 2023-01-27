namespace Prototype;

/// the intent is to specify the kinds of objects to create using a prototypical instance
/// and create new object by copying this prototype
///
/// It allows to copying existing objects without making code dependent on it's concrete classes
/// Prototype might return shallow or deep copy

// prototype
public abstract class Person {
    public abstract string Name { get; set; }
    public abstract Person Clone();
}

// concrete prototype1
public class Manager : Person {
    public override string Name { get; set; }
    public Manager(string name) {
        Name = name;
    }
    public override Person Clone() {
        return (Person)MemberwiseClone();
    }
}

public class Employee : Person {
    public override string Name { get; set; }
    public Manager Manager { get; set; }
    public Employee(string name, Manager manager) {
        Name = name;
        Manager = manager;
    }
    // shallow copy
    public override Person Clone() {
        return (Person)MemberwiseClone();
    }
}

// concrete prototype2



