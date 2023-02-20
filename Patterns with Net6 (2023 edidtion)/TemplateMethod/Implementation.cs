namespace TemplateMethod;

// intent is to create an algorithm structure and ability to change the algorithm internal implementation without 
// changing an algorithm structure itself.


/// <summary>
/// Main algorithm structure. A template
/// </summary>
public abstract class MailProvider {
    public virtual void FindServer() {  // might be overriden i.e. change algorithm internal details
        Console.WriteLine("Server is found");
    }

    public abstract void AuthenticateServer(); // must be overriden i.e. change algorithm internal details

    public void ParseHtmlPage() { 
        Console.WriteLine("Page is parsed"); 
    }

    // template method
    public void ExecuteMail() { // order of template algorithm could not be changed
        FindServer();
        AuthenticateServer();
        ParseHtmlPage();
    }
}



public class GmailProvider : MailProvider {
    public override void AuthenticateServer() {
        Console.WriteLine("Gmail server is authenticated");
    }
}

public class OutlookProvider : MailProvider {
    public override void AuthenticateServer() {
        Console.WriteLine("Outlook server is authenticated");
    }

    public override void FindServer() {
        Console.WriteLine("Outlook server is found");    
    }
}
