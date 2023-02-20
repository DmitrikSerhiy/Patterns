using ChainOfResponsibility;

Console.Title = "Chain of Responsibility";

var doc1 = new CoRDocument("text.txt", true, true, true);
var doc2 = new CoRDocument("text.txt", false, true, true);
var doc3 = new CoRDocument("text.txt", true, true, false);


var managerHandler = new ManagerHandler();
managerHandler
    .SetSuccessor(new EditorHandler())
    .SetSuccessor(new DirectorHandler());

Console.WriteLine("result of first foc");
var result1 = managerHandler.Handle(doc1);
Console.WriteLine("General validation result: " + result1);
Console.WriteLine("===");

Console.WriteLine("result of second foc");
var result2 = managerHandler.Handle(doc2);
Console.WriteLine("General validation result: " + result2);
Console.WriteLine("===");

Console.WriteLine("result of third foc");
var result3 = managerHandler.Handle(doc3);
Console.WriteLine("General validation result: " +result3);
Console.WriteLine("===");


Console.ReadKey();