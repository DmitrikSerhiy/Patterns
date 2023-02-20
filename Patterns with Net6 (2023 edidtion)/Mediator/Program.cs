using Mediator;

Console.Title = "Mediator";

IChatRoom chatRoom = new ChatRoom();

var player1 = new Player("Nick");
var player2 = new Player("Kile");
var player3 = new Player("Paul");
var user1 = new User("Kate");
var user2 = new User("Bety");

chatRoom.Register(player1);
chatRoom.Register(player2);
chatRoom.Register(player3);
chatRoom.Register(user1);
chatRoom.Register(user2);


user1.Send("Hi everyone");

Console.ReadLine();