using Command;

Console.Title = "Command";

var commandManager = new CommandManager();

var emp = new Employee
{
    Age = 35,
    Name = "Joe"
};


var changeEmpNameCommand = new UpdateUserNameCommand(emp, "Zelya:)");
var changeEmpAgeCommand = new UpdateUserAgeCommand(emp, 46);

commandManager.Invoke(changeEmpAgeCommand);
commandManager.Invoke(changeEmpNameCommand);

Console.ReadKey();