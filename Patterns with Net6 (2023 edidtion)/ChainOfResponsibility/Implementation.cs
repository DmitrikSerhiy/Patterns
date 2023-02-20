namespace ChainOfResponsibility;

// intent to avoid coupling the sender and receiver by giving more then one object to handle it


public interface IHandler<T> where T : class {
    IHandler<CoRDocument> SetSuccessor(IHandler<T> hander);
    bool Handle(T request);
}






public class CoRDocument {
    public string Title { get; set; }
    public bool ApprovedByManager { get; set; }
    public bool ApprovedByEditor { get; set; }
    public bool ApprovedByDirector { get; set; }
    
    public CoRDocument(string title, bool approvedByManager, bool approvedByEditor, bool approvedByDirector) {
        Title = title;
        ApprovedByManager = approvedByManager;
        ApprovedByEditor = approvedByEditor;
        ApprovedByDirector = approvedByDirector;
    }
}


public class ManagerHandler : IHandler<CoRDocument> {
    private IHandler<CoRDocument> _next;
    public IHandler<CoRDocument> SetSuccessor(IHandler<CoRDocument> hander) {
        _next = hander;
        return _next;
    }

    public bool Handle(CoRDocument request) {
        if (request.ApprovedByManager) {
            Console.WriteLine("Approved by Manager");
            
            return _next?.Handle(request) ?? true;
        }
        
        Console.WriteLine("Doc is NOT approved by Manager");
        return false;
    }
}

public class EditorHandler : IHandler<CoRDocument> {
    private IHandler<CoRDocument> _next;
    public IHandler<CoRDocument> SetSuccessor(IHandler<CoRDocument> hander) {
        _next = hander;
        return _next;
    }

    public bool Handle(CoRDocument request) {
        if (request.ApprovedByEditor) {
            Console.WriteLine("Approved by Editor");
            
            return _next?.Handle(request) ?? true;
        }
        
        Console.WriteLine("Doc is NOT approved by Editor");
        return false;
    }
}

public class DirectorHandler : IHandler<CoRDocument> {
    private IHandler<CoRDocument>? _next;
    public IHandler<CoRDocument> SetSuccessor(IHandler<CoRDocument> hander) {
        _next = hander;
        return _next;
    }

    public bool Handle(CoRDocument request) {
        if (request.ApprovedByDirector) {
            Console.WriteLine("Approved by Director");
            
            return _next?.Handle(request) ?? true;
        }
        
        Console.WriteLine("Doc is NOT approved by Director");
        return false;
    }
}