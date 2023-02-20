using Memento;

Console.Title = "Memento";


var commandManager = new CommandManager();

var emp = new Employee
{
    Age = 35,
    Name = "Joe"
};


var changeEmpNameCommand = new UpdateUserNameCommand(emp, "Zelya:)");
var changeEmpAgeCommand = new UpdateUserAgeCommand(emp, 46);

Console.WriteLine("Initial ==========");
Console.WriteLine(emp.Name);
Console.WriteLine(emp.Age);

commandManager.Invoke(changeEmpAgeCommand);
Console.WriteLine("after age update ==========");
Console.WriteLine(emp.Name);
Console.WriteLine(emp.Age);

commandManager.Invoke(changeEmpNameCommand);
Console.WriteLine("after name update ==========");
Console.WriteLine(emp.Name);
Console.WriteLine(emp.Age);


commandManager.Undo();
Console.WriteLine("after undo  ==========");
Console.WriteLine(emp.Name);
Console.WriteLine(emp.Age);

commandManager.Undo();
Console.WriteLine("after second undo ==========");
Console.WriteLine(emp.Name);
Console.WriteLine(emp.Age);
