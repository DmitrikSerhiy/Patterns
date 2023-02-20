namespace Strategy;

// intent is to define a family of algorithms which can be used interchangeably
// strategy makes the algorithm very independent from the client (Context)

/// <summary>
/// Strategy
/// </summary>
public interface IExportService {
    void Export(Order order);
}

public class ExportJsonService : IExportService {
    public void Export(Order order) {
        Console.WriteLine("Exported in json");
    }
}

public class ExportXmlService : IExportService {
    public void Export(Order order) {
        Console.WriteLine("Exported in xml");
    }
}


/// <summary>
/// Context
/// </summary>
public class Order {
    public string Details { get; set; }
    public int Price { get; set; }
    
    public IExportService? ExportService { get; set; } // it does not depend on concrete implementation!

    public void Export() {
        ExportService?.Export(this);
    }
}