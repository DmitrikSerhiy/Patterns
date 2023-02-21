namespace State;

// intent to provide an object state which may change under specified conditions
// object internal state changes its' behavior

/// <summary>
/// Context
/// </summary>
public class BankAccount {
    public BankAccountState State { get; set; }
    public decimal Balance => State.Balance;

    public BankAccount(decimal amount) {
        State = new RegularState(amount, this);
    }
    
    public void Deposite(decimal amount) {
        State.Deposite(amount);
    }

    public void Withdraw(decimal amount) {
        State.Withdraw(amount);
    }

    public void Display() {
        Console.WriteLine($"State: {State.GetType().Name}. Balance: {Balance}");
    }
}

/// <summary>
/// State
/// </summary>
public abstract class BankAccountState {
    public BankAccount BankAccount { get; protected set; }
    public decimal Balance { get; protected set; }
    public abstract void Deposite(decimal amount);
    public abstract  void Withdraw(decimal amount);
}

/// <summary>
/// Concrete states
/// </summary>
public class RegularState : BankAccountState {

    public RegularState(decimal balance, BankAccount bankAccount) {
        Balance = balance;
        BankAccount = bankAccount;
    }
    
    public override void Deposite(decimal amount) {
        Console.WriteLine($"Depositing {amount} amount");
        Balance += amount;
    }

    public override void Withdraw(decimal amount) {
        Console.WriteLine($"Withdrowing {amount} amount");
        Balance -= amount;
        if (Balance < 0) {
            BankAccount.State = new OverdrawnState(Balance, BankAccount);
        }
    }
}

public class OverdrawnState : BankAccountState {
    
    public OverdrawnState(decimal balance, BankAccount bankAccount) {
        Balance = balance;
        BankAccount = bankAccount;
    }
    public override void Deposite(decimal amount) {
        Console.WriteLine($"Depositing {amount} amount");
        Balance += amount;
        
        if (Balance >= 0) {
            BankAccount.State = new RegularState(Balance, BankAccount);
        }
    }

    public override void Withdraw(decimal amount) {
        Console.WriteLine($"Cannot withdraw. Balance: {Balance}");

    }
}


