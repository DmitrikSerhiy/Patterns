using Prototype;

Console.Title = "Prototype";


var manager = new Manager("Olha");
var managerClone = manager.Clone();

Console.WriteLine($"Manager was cloned: {managerClone.Name}");


var employee = new Employee("Timmy", manager);
var employeeClone = employee.Clone();

Console.WriteLine($"Employee was cloned: {employeeClone.Name}. " +
                  $"With manager: {employee.Manager.Name}");