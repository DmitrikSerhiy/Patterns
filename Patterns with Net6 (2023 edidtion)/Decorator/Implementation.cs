namespace Decorator;

// intent to attach additional responsibilities or functionality to an object dynamically
// it's an alternative to subclassing


/// <summary>
/// Component (an object to decorate)
/// </summary>
public interface IMailSender {
    public bool SendMail();
}

/// <summary>
/// Concrete Components
/// </summary>
public class DesktopMailSender : IMailSender {
    public bool SendMail() {
        Console.WriteLine("Desktop sent an email");
        return true;
    }
}

public class WebMailSender : IMailSender {
    public bool SendMail() {
        Console.WriteLine("Web sent an email");
        return true;
    }
}


/// <summary>
/// Decorator
/// </summary>
public abstract class MailSenderDecoratorBase : IMailSender {
    private readonly IMailSender _sender;

    public MailSenderDecoratorBase(IMailSender sender) {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
    }
    public virtual bool SendMail() {
        return _sender.SendMail();
    }
}

/// <summary>
/// Concrete decorators (these contain decorated functionality.)
/// concrete decorators decorated an IMailSender object
/// </summary>
public class StatisticsDecorator : MailSenderDecoratorBase {
    public StatisticsDecorator(IMailSender sender) : base(sender) {
    }

    public override bool SendMail() {
        Console.WriteLine("Some decoration from statistic decorator");
        return base.SendMail();
    }
}

public class MessagesDecorator : MailSenderDecoratorBase {
    public MessagesDecorator(IMailSender sender) : base(sender) {
    }

    public override bool SendMail() {
        Console.WriteLine("Some decoration from message decorator");
        return base.SendMail();
    }
}