namespace Observer;

// intent to define one to many relationship between the objects so that one object change the state, others are notified
// it is also known as pub-sub (from publish-subscribe)


public class TicketChange {
    public TicketChange(int amount) {
        Amount = amount;
    }

    public int Amount { get; set; }
}


/// <summary>
/// Subject
/// </summary>
public abstract class TicketChangeNotifier {
    private List<ITicketChangeListener> _observers = new List<ITicketChangeListener>();
    
    public void AddObserver(ITicketChangeListener observer) {
        _observers.Add(observer);
    }
    
    public void RemoveObserver(ITicketChangeListener observer) {
        _observers.Remove(observer);
    }

    public void Notify(TicketChange ticketChange) {
        foreach (var o in _observers) {
            o.ReceiveTicketChangeNotification(ticketChange);
        }
    }
    
}


/// <summary>
/// Observer
/// </summary>
public interface ITicketChangeListener {
    void ReceiveTicketChangeNotification(TicketChange ticketChange);
}


/// <summary>
/// Concrete subject
/// </summary>
public class OrderTicketService : TicketChangeNotifier {
    public void CompleteTicketSale(int amount) {
        Console.WriteLine($"Order is completed with amount {amount}");
        Notify(new TicketChange(amount));
    }
}

/// <summary>
/// Concrete observers
/// </summary>
public class OfficeTicketService : ITicketChangeListener {
    public void ReceiveTicketChangeNotification(TicketChange ticketChange) {
        Console.WriteLine($"Ticket notification received by office: {ticketChange.Amount}");
    }
}

public class StockTicketService : ITicketChangeListener {
    public void ReceiveTicketChangeNotification(TicketChange ticketChange) {
        Console.WriteLine($"Ticket notification received by stock: {ticketChange.Amount}");
    }
}

