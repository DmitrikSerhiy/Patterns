using Visitor;

Console.Title = "Visitor";


var visitor = new global::Visitor.Visitor();

var container = new Container();
container.Employees.Add( new Employee("Mike"));
container.Employees.Add( new Employee("Kaly"));

container.Customers.Add( new Customer("Kira"));
container.Customers.Add( new Customer("Sarah"));
container.Customers.Add( new Customer("Ban"));

container.Accept(visitor);

Console.ReadKey();

