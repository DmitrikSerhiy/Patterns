namespace Visitor;

// intent to represent the operation to be performed on the objects elements
// it let define new operation on elements without changing elements themself

/// <summary>
/// Concrete elements
/// </summary>
public class Customer : IElement {
    public string Name { get; set; }
    public decimal Discount { get; } = 5.0m;
    public Customer(string name) {
        Name = name;
    }

    public void Accept(IVisitor visitor) {
        Console.WriteLine($"Visited customer: {Name}");
        visitor.Visit(this);
    }
}

public class Employee: IElement {
    public string Name { get; set; }
    public decimal Discount { get; } = 10.0m;
    public Employee(string name) {
        Name = name;
    }

    public void Accept(IVisitor visitor) {
        Console.WriteLine($"Visited employee: {Name}");
        visitor.Visit(this);
    }
}

/// <summary>
/// Visitor
/// </summary>
public interface IVisitor {
    void Visit(IElement element);
}

/// <summary>
/// element
/// </summary>
public interface IElement {
    void Accept(IVisitor visitor);
}

/// <summary>
/// Concrete visitor
/// </summary>
public class Visitor : IVisitor {
    private void VisitCustomer(Customer customer) {
        Console.WriteLine($"Customer got an discount of: {customer.Discount}");
    }

    private void VisitEmployee(Employee employee) {
        Console.WriteLine($"Employee got an discount of: {employee.Discount}");
    }

    public void Visit(IElement element) {
        if (element is Customer) {
            VisitCustomer((Customer)element);
        } else if (element is Employee) {
            VisitEmployee((Employee)element);
        }
    }
}


public class Container {
    public List<Employee> Employees = new List<Employee>();
    public List<Customer> Customers = new List<Customer>();

    public void Accept(IVisitor visitor) {
        foreach (var customer in Customers) {
            customer.Accept(visitor);
        }

        foreach (var employee in Employees) {
            employee.Accept(visitor);
        }
    }
}