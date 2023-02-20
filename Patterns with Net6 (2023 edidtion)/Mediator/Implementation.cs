namespace Mediator;


// intent is to create an object that encapsulates how a set of objects may interact
// it's basically a chat room

/// <summary>
/// Mediatr
/// </summary>
public interface IChatRoom {
    public void Register(ChatMember member);
    public void Send(string message, string from);
}


public class ChatMember {
    public string Name { get; set; }
    private IChatRoom? _chatRoom;

    public ChatMember(string name) {
        Name = name;
    }

    public void SetChatRoom(IChatRoom chatRoom) {
        _chatRoom = chatRoom;
    }

    public void Send(string message) {
        Console.WriteLine($"{Name} sent a message: '{message}'");
        _chatRoom?.Send(message, Name);
    }

    public virtual void Receive(string message, string from) {
        Console.WriteLine($"{Name} received message '{message}' from {from}");
        Console.WriteLine("===");
    }
}

/// <summary>
/// concrete chats
/// </summary>
public class Player : ChatMember {
    public Player(string name) : base(name) { }

    public override void Receive(string message, string from) {
        Console.WriteLine(nameof(Player) + " received a message: ");
        base.Receive(message, from);
    }
}

public class User : ChatMember {
    public User(string name) : base(name) { }

    public override void Receive(string message, string from) {
        Console.WriteLine(nameof(User) + " received a message: ");
        base.Receive(message, from);
    }
}



public class ChatRoom : IChatRoom {
    private readonly Dictionary<string, ChatMember> _members = new Dictionary<string, ChatMember>();
    public void Register(ChatMember member) {
        member.SetChatRoom(this);
        if (!_members.ContainsKey(member.Name)) {
            _members.Add(member.Name, member);
        }
    }

    public void Send(string message, string from) {
        foreach (var member in _members.Values.Where(mem => mem.Name != from)) {
            member.Receive(message, from);
        }
    }
}
