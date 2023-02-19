namespace Proxy;

// intent is to provide a surrogate or placeholder for another object to control access to it

/// <summary>
/// Real subject
/// </summary>
public class PDocument : IDoc {
    
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? AuthorId { get; set; }
    private string FileName { get; }
    
    public PDocument(string fileName) {
        FileName = fileName;
        LoadDoc();
    }

    private void LoadDoc() {
        Console.WriteLine("Loading file...");
        Thread.Sleep(2000);
    }

    public void DisplayDoc() {
        Console.WriteLine($"Content: {Content}");
    }
}

public interface IDoc {
    void DisplayDoc();
}




public class ProxyPDocument : IDoc {

    private PDocument _realDoc; 
    private string FileName { get; }

    public ProxyPDocument(string fileName) {
        FileName = fileName;
    }

    public void DisplayDoc() {
        Console.WriteLine("Proxy display");
        if (_realDoc is null) {
            _realDoc = new PDocument(FileName);
        }
        
        _realDoc.DisplayDoc();
    }
}



