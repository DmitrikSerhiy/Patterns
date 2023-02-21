using Interpreter;

Console.Title = "Interpreter";

var context = new CirilContext("ш");
CirilExpression interpreter = new CirilOneExpression();


interpreter.Interpret(context);

Console.WriteLine(context.Output);

Console.ReadKey();