namespace Command;

// intent to decouple the class that invokes an operation from the operation itself. 
// command its a wrapper around certain operations which is intent to be used by the context
// each command is tread in the same way. So, it's easy to implement undo functionality within this pattern
// (just add Undo method to ICommand interface and implement it with operation which is reverse to the one is in Execute() method)

// command encapsulates request into an objects. It allows to queue, parameterize and support undoable operations

// it is usually used by 'invoker' and 'receiver' in UI libs. 
// invoke ICommand => receive ICommand

/// <summary>
/// Context
/// </summary>
public class Employee {
    public int Id { get; } = 100;
    public string Name { get; set; }
    
    public int Age { get; set; }
}


public interface IEmployeeRepository {
    void UpdateName(Employee emp, string name);
    void UpdateAge(Employee emp, int age);
    void SaveChanges();
}

/// <summary>
/// Receiver
/// </summary>
public class EmployeeRepository : IEmployeeRepository{
    public void UpdateName(Employee emp, string name) {
        Console.WriteLine("Name was changed");
        emp.Name = name;
    }

    public void UpdateAge(Employee emp, int age) {
        Console.WriteLine("Age was changed");
        emp.Age = age;
    }

    public void SaveChanges() {
        Console.WriteLine("Saved");
    }
}

/// <summary>
/// Command
/// </summary>
public interface ICommand {
    public void Execute();
    public bool CanExecute();
}

// Concrete commands
public class UpdateUserNameCommand : ICommand {
    private readonly Employee _emp;
    private readonly string _name;

    private IEmployeeRepository _repository;

    public UpdateUserNameCommand(Employee emp, string name) { 
        _emp = emp;
        _name = name; 
        _repository = new EmployeeRepository(); // should be injected
    }
    public void Execute() {
        _repository.UpdateName(_emp, _name);
        _repository.SaveChanges();
    }

    public bool CanExecute() {
        return true; // some conditions might be here
    }
}

public class UpdateUserAgeCommand : ICommand {
    private readonly Employee _emp;
    private readonly int _age;

    private IEmployeeRepository _repository;

    public UpdateUserAgeCommand(Employee emp, int age) { 
        _emp = emp;
        _age = age;
        _repository = new EmployeeRepository();// should be injected
    }
    public void Execute() {
        _repository.UpdateAge(_emp, _age);
        _repository.SaveChanges();
    }
    
    public bool CanExecute() {
        return true; // some conditions might be here
    }
}

/// <summary>
/// Invoker
/// </summary>
public class CommandManager {
    public void Invoke(ICommand command) {
        if (command.CanExecute()) {
            command.Execute();
        }
    }
}