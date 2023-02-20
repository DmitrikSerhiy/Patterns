using System.Text;

namespace Memento;

// intent to capture and use the internal state of the object so it could be restored from previous state 


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
    public void Undo();

    IMemento CreateMemento();
    void RestoreMemento(IMemento memento);
}

// Concrete commands and originators
// these are responsible for memento as well
public class UpdateUserNameCommand : ICommand {
    private Employee _emp;
    private string _name;
    private string? _previousName;

    private IEmployeeRepository _repository;

    public UpdateUserNameCommand(Employee emp, string name) { 
        _emp = emp;
        _name = name; 
        _repository = new EmployeeRepository(); // should be injected
    }
    public void Execute() {
        _previousName = _emp.Name;
        _repository.UpdateName(_emp, _name);
        _repository.SaveChanges();
    }

    public bool CanExecute() {
        return true; // some conditions might be here
    }

    public void Undo() {
        _repository.UpdateName(_emp, _previousName);
    }

    public IMemento CreateMemento() {
        return new UpdateUserNameMemento(new StringBuilder(_name).ToString());
    }

    public void RestoreMemento(IMemento memento) {
        var internalMemento = memento as UpdateUserNameMemento;
        _name = internalMemento!.Name;
    }
}

public class UpdateUserAgeCommand : ICommand {
    private Employee _emp;
    private int _age;
    public int _previousAge;

    private IEmployeeRepository _repository;

    public UpdateUserAgeCommand(Employee emp, int age) { 
        _emp = emp;
        _age = age;
        _repository = new EmployeeRepository();// should be injected
    }
    public void Execute() {
        _previousAge = _emp.Age;
        _repository.UpdateAge(_emp, _age);
        _repository.SaveChanges();
    }
    
    public bool CanExecute() {
        return true; // some conditions might be here
    }

    public void Undo() {
        _repository.UpdateAge(_emp, _previousAge);
        _repository.SaveChanges();
    }

    public IMemento CreateMemento() {
        return new UpdateUserAgeMemento(_emp.Age);
    }
    
    public void RestoreMemento(IMemento memento) {
        var internalMemento = memento as UpdateUserAgeMemento;
        _age = internalMemento!.Age;
    }
}

/// <summary>
/// Invoker and caretacker
/// </summary>
public class CommandManager {
    private readonly Stack<IMemento> _mementoes = new Stack<IMemento>();
    private readonly Stack<ICommand> _commands = new Stack<ICommand>();

    public void Invoke(ICommand command) {
        if (command.CanExecute()) {
            _mementoes.Push(command.CreateMemento());
            _commands.Push(command);
            command.Execute();
        }
    }

    public void Undo() {
        if (_mementoes.Count > 0) {
            var command = _commands.Pop();
            command.RestoreMemento(_mementoes.Pop());
            command.Undo();
        }
    }
}


public interface IMemento {
    
}

/// <summary>
/// Memento
/// </summary>
public class UpdateUserAgeMemento : IMemento {
    public int Age { get; }

    public UpdateUserAgeMemento(int age) {
        Age = age;
    }
}


public class UpdateUserNameMemento : IMemento {
    public string Name { get; }

    public UpdateUserNameMemento(string name) {
        Name = name;
    }
}
